using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class ActividadesController : Controller
    {
        public ActionResult Actividades()
        {
            if (User.IsInRole("Web"))
                RedirectToAction("Login", "Account");
                return View();
            
        }

        public UiContainer GenerarId(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var mu = new ActividadManagement();
            var Cod = 0;
            
            
            

            var listaId = mu.RetrieveAllActividades<Actividad>();
            
           
                        
            foreach (var estadoActividad in listaId)
            {
                if (estadoActividad.Estado_Actividad.Equals("INACTIVO"))
                {
                    Cod = estadoActividad.IdActividad;

                }
                else
                {
                    Cod = estadoActividad.IdActividad;
                }
            }



            txtId.Value = Convert.ToString(Cod + 1);
            txtId.Disabled = true;

            uiContainer.UpdateModel(txtId);
            return uiContainer;
            
        }

        // se debe pasar el parametro de tipo texto que tiene el AJAX
        public UiContainer CreateActividad(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var Cod = 0;
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var tblActividades = uiContainer.GetCtrlModel<CtrlTableModel>("tblActividades");

            //Creacion del usuario
            var mu = new ActividadManagement();
            var actividad = new Actividad()
            {
                IdActividad = Convert.ToInt32(txtId.Value),
                NombreActividad = txtNombre.Value,
                DescripcionActividad = txtDescripcion.Value
            };

            mu.CreateActividad(actividad);

            //Limpiar campos
            //txtId.Value = "";
            txtNombre.Value = "";
            txtDescripcion.Value = "";

            var list = mu.RetrieveAllActividades<Actividad>();

            tblActividades.RowList.Clear();

            foreach (var act in list)
            {
                tblActividades.RowList.Add(new List<string>()
                {
                    act.IdActividad.ToString(), act.NombreActividad, act.DescripcionActividad
                    
                });
            }

            var listaId = mu.RetrieveAllActividades<Actividad>();

            foreach (var estadoActividad in listaId)
            {
                if (estadoActividad.Estado_Actividad.Equals("INACTIVO"))
                {
                    Cod = estadoActividad.IdActividad;

                }
                else
                {
                    Cod = estadoActividad.IdActividad;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;
            

            uiContainer.UpdateModel(tblActividades);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
            
            return uiContainer;
        }

        public UiContainer RetrieveActividad(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            var mu = new ActividadManagement();
            var actividad = new Actividad()
            {
                IdActividad = Convert.ToInt32(txtId.Value)
            };

            actividad = mu.RetrieveActividad(actividad);

            if (actividad == null)
            {
                uiContainer.InformationMessage = "La actividad " + txtId.Value + " no existe";
                txtNombre.Value = "";
                txtDescripcion.Value = "";
            }
            else
            {
                txtId.Value = actividad.IdActividad.ToString();
                txtId.Disabled = true;
                txtNombre.Value = actividad.NombreActividad;
                txtDescripcion.Value = actividad.DescripcionActividad;

                btnEliminar.Value = "Eliminar";
                btnEliminar.ButtonType = "danger";
                btnEliminar.Disabled = false;
                btnEliminar.EvtOnClick = "deleteActividad()";

                btnActualizar.Value = "Actualizar";
                btnActualizar.ButtonType = "warning";
                btnActualizar.Disabled = false;
                btnActualizar.EvtOnClick = "updateActividad()";
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
            var tblActividades = uiContainer.GetCtrlModel<CtrlTableModel>("tblActividades");

            var mu = new ActividadManagement();
            var list = mu.RetrieveAllActividades<Actividad>();

            tblActividades.RowList.Clear();

            foreach (var actividad in list)
            {
                if (actividad.Estado_Actividad.Equals("INACTIVO"))
                {

                }
                else
                {
                    tblActividades.RowList.Add(new List<string>()
                {
                    actividad.IdActividad.ToString(), actividad.NombreActividad, actividad.DescripcionActividad});
                }
               
            }

            uiContainer.UpdateModel(tblActividades);

            return uiContainer;
        }

        public UiContainer BindFields(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblActividades = uiContainer.GetCtrlModel<CtrlTableModel>("tblActividades");
            var actividad = new Actividad(tblActividades.GetSelectedRow());
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            txtId.Value = actividad.IdActividad.ToString();
            txtId.Disabled = true;
            txtNombre.Value = actividad.NombreActividad;
            txtDescripcion.Value = actividad.DescripcionActividad;

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = true;
            btnGuardar.EvtOnClick = " ";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "danger";
            btnEliminar.Disabled = false;
            btnEliminar.EvtOnClick = "deleteActividad()";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "warning";
            btnActualizar.Disabled = false;
            btnActualizar.EvtOnClick = "updateActividad()";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
            uiContainer.UpdateModel(btnGuardar);
            uiContainer.UpdateModel(btnEliminar);
            uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
        }


        public UiContainer UpdateActividad(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var tblActividades = uiContainer.GetCtrlModel<CtrlTableModel>("tblActividades");

            //Creacion del usuario
            var mu = new ActividadManagement();
            var actividad = new Actividad()
            {
                IdActividad = Convert.ToInt32(txtId.Value),
                NombreActividad = txtNombre.Value,
                DescripcionActividad = txtDescripcion.Value
            };

            mu.UpdateActividad(actividad);

            txtId.Disabled = true;

            var list = mu.RetrieveAllActividades<Actividad>();

            tblActividades.RowList.Clear();

            foreach (var act in list)
            {
                tblActividades.RowList.Add(new List<string>()
                {
                    act.IdActividad.ToString(), act.NombreActividad, act.DescripcionActividad
                });
            }

            uiContainer.UpdateModel(tblActividades);
            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);

            return uiContainer;
        }


        public UiContainer DeleteActividad(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");
            var tblActividades = uiContainer.GetCtrlModel<CtrlTableModel>("tblActividades");

            //Creacion del usuario
            var mu = new ActividadManagement();
            var actividad = new Actividad()
            {
                IdActividad = Convert.ToInt32(txtId.Value)
            };

            mu.DeleteActividad(actividad);

            var list = mu.RetrieveAllActividades<Actividad>();

            tblActividades.RowList.Clear();

            foreach (var act in list)
            {
                tblActividades.RowList.Add(new List<string>() { act.IdActividad.ToString(), act.NombreActividad, act.DescripcionActividad });
            }

            //LimpiarCampos
            txtId.Value = "";
            txtId.Disabled = true;
            txtNombre.Value = "";
            txtDescripcion.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createActividad()";

            btnEliminar.Value = "Eliminar";
            btnEliminar.ButtonType = "info";
            btnEliminar.Disabled = true;
            btnEliminar.EvtOnClick = " ";

            btnActualizar.Value = "Actualizar";
            btnActualizar.ButtonType = "info";
            btnActualizar.Disabled = true;
            btnActualizar.EvtOnClick = " ";

            uiContainer.UpdateModel(tblActividades);
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
            var mu = new ActividadManagement();
            //Limpiar campos
            //txtId.Value = "";

            //BUSCA EN LA TABLA DE ACTIVIDADES EL ULTIMO ID ACTIVIDAD GENERADO Y LE SUMA UNO MAS

            var list = mu.RetrieveAllActividades<Actividad>();

            foreach (var estadoActividad in list)
            {
                if (estadoActividad.Estado_Actividad.Equals("INACTIVO"))
                {
                    Cod = estadoActividad.IdActividad;

                }
                else
                {
                    Cod = estadoActividad.IdActividad;
                }
            }

            Cod = Cod + 1;

            txtId.Value = Convert.ToString(Cod);
            txtId.Disabled = true;
            



            //***************************
            txtId.Disabled = true;
            txtNombre.Value = "";
            txtDescripcion.Value = "";

            btnGuardar.Value = "Guardar";
            btnGuardar.ButtonType = "info";
            btnGuardar.Disabled = false;
            btnGuardar.EvtOnClick = "createActividad()";

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