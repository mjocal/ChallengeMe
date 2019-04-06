using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class PremiosController : Controller
    {
        public ActionResult Premios()
        {
            return View();
        }

        public UiContainer GenerarId(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var mu = new PremioManagement();
            var Cod = 0;

            var listaId = mu.RetrieveAllPremios<Premio>();

            foreach (var estadoPremio in listaId)
            {
                if (estadoPremio.Estado_Premio.Equals("INACTIVO"))
                {
                    Cod = estadoPremio.IdPremio;
                }
            else
                {
                    Cod = estadoPremio.IdPremio;
                }
            }

            txtId.Value = Convert.ToString(Cod + 1);
            txtId.Disabled = true;

            uiContainer.UpdateModel(txtId);
            return uiContainer;
        }

        public UiContainer CreatePremio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var Cod = 0;
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var tblPremios = uiContainer.GetCtrlModel<CtrlTableModel>("tblPremios");

            var mu = new PremioManagement();
            var premio = new Premio()
            {
                IdPremio = Convert.ToInt32(txtId.Value),
                NombrePremio = txtNombre.Value,
                DescripcionPremio = txtDescripcion.Value
            };

            mu.CreatePremio(premio);

            txtNombre.Value = "";
            txtDescripcion.Value = "";

            var list = mu.RetrieveAllPremios<Premio>();

            tblPremios.RowList.Clear();

            foreach (var act in list)
            {
                tblPremios.RowList.Add(new List<string>()
                {
                act.IdPremio.ToString(), act.NombrePremio, act.DescripcionPremio
                });
            }

            var listaId = mu.RetrieveAllPremios<Premio>();

            foreach (var estadoPremio in listaId)
            {
                if (estadoPremio.Estado_Premio.Equals("INACTIVO"))
                {
                    Cod = estadoPremio.IdPremio;
                }
                else
                {
                    Cod = estadoPremio.IdPremio;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            uiContainer.UpdateModel(tblPremios);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);

            return uiContainer;
        }

        public UiContainer RetrievePremio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            var mu = new PremioManagement();
            var premio = new Premio()
            {
                IdPremio = Convert.ToInt32(txtId.Value)
            };

            premio = mu.RetrievePremio(premio);

            if (premio == null)
            {
                uiContainer.InformationMessage = "El premio " + txtId.Value + " no existe";
                txtNombre.Value = "";
                txtDescripcion.Value = "";
            }
            else
            {
                txtId.Value = premio.IdPremio.ToString();
                txtId.Disabled = true;
                txtNombre.Value = premio.NombrePremio;
                txtDescripcion.Value = premio.DescripcionPremio;

                btnEliminar.Value = "Eliminar";
                btnEliminar.ButtonType = "danger";
                btnEliminar.Disabled = false;
                btnEliminar.EvtOnClick = "deletePremio()";

                btnActualizar.Value = "Actualizar";
                btnActualizar.ButtonType = "warning";
                btnActualizar.Disabled = false;
                btnActualizar.EvtOnClick = "updatePremio()";
            }

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }

        public UiContainer RetrieveAll(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblPremios = uiContainer.GetCtrlModel<CtrlTableModel>("tblPremios");

            var mu = new PremioManagement();
            var list = mu.RetrieveAllPremios<Premio>();

            tblPremios.RowList.Clear();

            foreach (var premio in list)
            {
                if (premio.Estado_Premio.Equals("INACTIVO"))
                {

                }
                else
                {
                    tblPremios.RowList.Add(new List<string>()
                    {
                    premio.IdPremio.ToString(), premio.NombrePremio, premio.DescripcionPremio
                    });
                }
            }

            uiContainer.UpdateModel(tblPremios);

            return uiContainer;
        }

        public UiContainer BindFields(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblPremios = uiContainer.GetCtrlModel<CtrlTableModel>("tblPremios");
            var premio = new Premio(tblPremios.GetSelectedRow());
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            txtId.Value = premio.IdPremio.ToString();
            txtId.Disabled = true;
            txtNombre.Value = premio.NombrePremio;
            txtDescripcion.Value = premio.DescripcionPremio;

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = true;
            btnGuardar.EvtOnClick = " ";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "danger";
            btnEliminar.Disabled = false;
            btnEliminar.EvtOnClick = "deletePremio()";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "warning";
            btnActualizar.Disabled = false;
            btnActualizar.EvtOnClick = "updatePremio()";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }


        public UiContainer UpdatePremio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var tblPremios = uiContainer.GetCtrlModel<CtrlTableModel>("tblPremios");

            var mu = new PremioManagement();
            var premio = new Premio()
            {
                IdPremio = Convert.ToInt32(txtId.Value),
                NombrePremio = txtNombre.Value,
                DescripcionPremio = txtDescripcion.Value
            };

            mu.UpdatePremio(premio);

            txtId.Disabled = true;

            var list = mu.RetrieveAllPremios<Premio>();

            tblPremios.RowList.Clear();

            foreach (var prem in list)
            {
                tblPremios.RowList.Add(new List<string>()
                {
                    prem.IdPremio.ToString(), prem.NombrePremio, prem.DescripcionPremio
                });
            }

            uiContainer.UpdateModel(tblPremios);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);

            return uiContainer;
        }


        public UiContainer DeletePremio(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var tblPremios = uiContainer.GetCtrlModel<CtrlTableModel>("tblPremios");

            var mu = new PremioManagement();
            var premio = new Premio()
            {
                IdPremio = Convert.ToInt32(txtId.Value)
            };

            mu.DeletePremio(premio);

            var list = mu.RetrieveAllPremios<Premio>();

            tblPremios.RowList.Clear();

            foreach (var act in list)
            {
                tblPremios.RowList.Add(new List<string>()
                {
                    act.IdPremio.ToString(), act.NombrePremio, act.DescripcionPremio
                });
            }

            txtId.Value = "";
            txtId.Disabled = true;
            txtNombre.Value = "";
            txtDescripcion.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createPremio()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(tblPremios);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
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
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var Cod = 0;

            var mu = new PremioManagement();
            var list = mu.RetrieveAllPremios<Premio>();

            foreach (var estadoPremio in list)
            {
                if (estadoPremio.Estado_Premio.Equals("INACTIVO"))
                {
                    Cod = estadoPremio.IdPremio;
                }
            else
                {
                    Cod = estadoPremio.IdPremio;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;

            txtId.Disabled = true;
            txtNombre.Value = "";
            txtDescripcion.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createPremio()";

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
            uiContainer.UpdateModel(txtDescripcion);
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
    }
}