using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class PatrocinadoresController : Controller
    {
        public ActionResult Patrocinadores()
        {
            return View();
        }

        public UiContainer GenerarId(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var mu = new PatrocinadorManagement();
            var Cod = 0;

            var listaId = mu.RetrieveAllPatrocinadores<Patrocinador>();

            foreach (var estadoPatrocinador in listaId)
            {
                if (estadoPatrocinador.Estado_Patrocinador.Equals("INACTIVO"))
                {
                    Cod = estadoPatrocinador.IdPatrocinador;
                }
                else
                {
                    Cod = estadoPatrocinador.IdPatrocinador;
                }
            }

            txtId.Value = Convert.ToString(Cod + 1);
            txtId.Disabled = true;

            uiContainer.UpdateModel(txtId);
            return uiContainer;
        }

        public UiContainer CreatePatrocinador(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var Cod = 0;
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var tblPatrocinadores = uiContainer.GetCtrlModel<CtrlTableModel>("tblPatrocinadores");

            var mu = new PatrocinadorManagement();
            var patrocinador = new Patrocinador()
            {
                IdPatrocinador = Convert.ToInt32(txtId.Value),
                NombrePatrocinador = txtNombre.Value,
                LogoPatrocinador = GetImageLogoFromByteArray(imgLogo)
            };

            mu.CreatePatrocinador(patrocinador);

            txtNombre.Value = "";
            imgLogo.ByteImage = default (byte[]);

            var list = mu.RetrieveAllPatrocinadores<Patrocinador>();

            tblPatrocinadores.RowList.Clear();

            // revisar logo del patrocinador
            foreach (var act in list)
            {
                tblPatrocinadores.RowList.Add(new List<string>()
                {
                    act.IdPatrocinador.ToString(), act.NombrePatrocinador, GetImageHtml(act.LogoPatrocinador)
                });
            }

            var listaId = mu.RetrieveAllPatrocinadores<Patrocinador>();

            foreach (var estadoPatrocinador in listaId)
            {
                if (estadoPatrocinador.Estado_Patrocinador.Equals("INACTIVO"))
                {
                    Cod = estadoPatrocinador.IdPatrocinador;
                }
                else
                {
                    Cod = estadoPatrocinador.IdPatrocinador;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            uiContainer.UpdateModel(tblPatrocinadores);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);

            return uiContainer;
        }

        public UiContainer RetrievePatrocinador(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            var mu = new PatrocinadorManagement();
            var patrocinador = new Patrocinador()
            {
                IdPatrocinador = Convert.ToInt32(txtId.Value)
            };

            patrocinador = mu.RetrievePatrocinador(patrocinador);

            if (patrocinador == null)
            {
                uiContainer.InformationMessage = "El patrocinador " + txtId.Value + " no existe";
                txtNombre.Value = "";
                imgLogo.ByteImage = default(byte[]);
            }
            else
            {
                txtId.Value = patrocinador.IdPatrocinador.ToString();
                txtId.Disabled = true;
                txtNombre.Value = patrocinador.NombrePatrocinador;
                imgLogo.ByteImage = GetByteArrayFromImageLogo(patrocinador.LogoPatrocinador);

                btnEliminar.Value = "Eliminar";
                btnEliminar.ButtonType = "danger";
                btnEliminar.Disabled = false;
                btnEliminar.EvtOnClick = "deletePatrocinador()";

                btnActualizar.Value = "Actualizar";
                btnActualizar.ButtonType = "warning";
                btnActualizar.Disabled = false;
                btnActualizar.EvtOnClick = "updatePatrocinador()";
            }

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer RetrieveAll(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblPatrocinadores = uiContainer.GetCtrlModel<CtrlTableModel>("tblPatrocinadores");

            var mu = new PatrocinadorManagement();
            var list = mu.RetrieveAllPatrocinadores<Patrocinador>();

            tblPatrocinadores.RowList.Clear();

            foreach (var patrocinador in list)
            {
                if (patrocinador.Estado_Patrocinador.Equals("INACTIVO"))
                {

                }
                else
                {
                    tblPatrocinadores.RowList.Add(new List<string>()
                    {
                        patrocinador.IdPatrocinador.ToString(), patrocinador.NombrePatrocinador, GetImageHtml(patrocinador.LogoPatrocinador)
                    });
                }
            }

            uiContainer.UpdateModel(tblPatrocinadores);

            return uiContainer;
        }


        public UiContainer BindFields(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblPatrocinadores = uiContainer.GetCtrlModel<CtrlTableModel>("tblPatrocinadores");            
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var patrocinador = new Patrocinador(tblPatrocinadores.GetSelectedRow());
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            txtId.Value = patrocinador.IdPatrocinador.ToString();
            txtId.Disabled = true;
            txtNombre.Value = patrocinador.NombrePatrocinador;
            imgLogo.ByteImage = GetByteArrayFromImageLogo(patrocinador.LogoPatrocinador);

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = true;
            btnGuardar.EvtOnClick = " ";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "danger";
            btnEliminar.Disabled = false;
            btnEliminar.EvtOnClick = "deletePatrocinador()";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "warning";
            btnActualizar.Disabled = false;
            btnActualizar.EvtOnClick = "updatePatrocinador()";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }


        public UiContainer UpdatePatrocinador(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var tblPatrocinadores = uiContainer.GetCtrlModel<CtrlTableModel>("tblPatrocinadores");

            var mu = new PatrocinadorManagement();
            var patrocinador = new Patrocinador()
            {
                IdPatrocinador = Convert.ToInt32(txtId.Value),
                NombrePatrocinador = txtNombre.Value,
                LogoPatrocinador = GetImageLogoFromByteArray(imgLogo)
            };

            mu.UpdatePatrocinador(patrocinador);

            txtId.Disabled = true;

            var list = mu.RetrieveAllPatrocinadores<Patrocinador>();

            tblPatrocinadores.RowList.Clear();

            foreach (var pat in list)
            {
                tblPatrocinadores.RowList.Add(new List<string>()
                {
                    pat.IdPatrocinador.ToString(), pat.NombrePatrocinador, GetImageHtml(pat.LogoPatrocinador)
                });
            }

            uiContainer.UpdateModel(tblPatrocinadores);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);

            return uiContainer;
        }


        public UiContainer DeletePatrocinador(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var tblPatrocinadores = uiContainer.GetCtrlModel<CtrlTableModel>("tblPatrocinadores");

            var mu = new PatrocinadorManagement();
            var patrocinador = new Patrocinador()
            {
                IdPatrocinador = Convert.ToInt32(txtId.Value)
            };

            mu.DeletePatrocinador(patrocinador);

            var list = mu.RetrieveAllPatrocinadores<Patrocinador>();

            tblPatrocinadores.RowList.Clear();

            foreach (var act in list)
            {
                tblPatrocinadores.RowList.Add(new List<string>()
                {
                    act.IdPatrocinador.ToString(), act.NombrePatrocinador, GetImageHtml(act.LogoPatrocinador)
                });
            }

            txtId.Value = "";
            txtId.Disabled = true;
            txtNombre.Value = "";
            imgLogo.ByteImage = default(byte[]);

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createPatrocinador()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(tblPatrocinadores);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer LimpiarCampos(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var imgLogo = uiContainer.GetCtrlModel<CtrlImageModel>("imgLogo");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var Cod = 0;

            var mu = new PatrocinadorManagement();
            var list = mu.RetrieveAllPatrocinadores<Patrocinador>();

            foreach (var patrocinador in list)
            {
                if (patrocinador.Estado_Patrocinador.Equals("INACTIVO"))
                {
                    Cod = patrocinador.IdPatrocinador;
                }
                else
                {
                    Cod = patrocinador.IdPatrocinador;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            txtId.Disabled = true;
            txtNombre.Value = "";
            imgLogo.ByteImage = default(byte[]);

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createPatrocinador()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(imgLogo);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer VolverAlInicio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);

            uiContainer.RedirectTo = "/Home/Index";

            return uiContainer;
        }

        public Image GetImageLogoFromByteArray(CtrlImageModel imgLogo)
        {
            byte[] byteArrayImage = imgLogo.ByteImage;
            Image image;

            if (byteArrayImage != null)
            {
                MemoryStream streamImage = new MemoryStream(byteArrayImage);
                image = Image.FromStream(streamImage);
            }
            else
            {
                image = null;
            }

            return image;
        }

        public byte[] GetByteArrayFromImageLogo(Image imgLogo)
        {
            using (var ms = new MemoryStream())
            {
                imgLogo.Save(ms, imgLogo.RawFormat);
                return ms.ToArray();
            }
        }

        private string GetImageHtml(Image logoPatrocinador)
        {
           string imageHtml = "<img id='' src='data:image/jpg;base64," + Convert.ToBase64String(GetByteArrayFromImageLogo(logoPatrocinador), Base64FormattingOptions.None) + "' width='42' height='42' />";

            return imageHtml;
        }

    }
}