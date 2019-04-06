using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Challengeme.ApiCore;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }


        public UiContainer RetrieveAll(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblEventos = uiContainer.GetCtrlModel<CtrlTableModel>("tblEventos");

            var mu = new EventoManagement();
            var list = mu.RetrieveAllEventos<Evento>();

            tblEventos.RowList.Clear();

            foreach (var evento in list)
            {
                tblEventos.RowList.Add(new List<string>()
                {
                    evento.IdEvento.ToString(), evento.NombreEvento, evento.DescripcionEvento
                });
            }

            uiContainer.UpdateModel(tblEventos);

            return uiContainer;
        }

        public UiContainer BindFields(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var tblEventos = uiContainer.GetCtrlModel<CtrlTableModel>("tblEventos");
            var eventos = new Evento(tblEventos.GetSelectedRow());
            var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");
            var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
            var txtDescripcion = uiContainer.GetCtrlModel<CtrlInputModel>("txtDescripcion");
            //var btnGuardar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnGuardar");
            //var btnEliminar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnEliminar");
            //var btnActualizar = uiContainer.GetCtrlModel<CtrlButtonModel>("btnActualizar");

            txtId.Value = eventos.IdEvento.ToString();
            txtId.Disabled = true;
            txtNombre.Value = eventos.NombreEvento;
            txtDescripcion.Value = eventos.DescripcionEvento;

            //btnGuardar.Value = "Guardar";
            //btnGuardar.ButtonType = "info";
            //btnGuardar.Disabled = true;
            //btnGuardar.EvtOnClick = " ";

            //btnEliminar.Value = "Eliminar";
            //btnEliminar.ButtonType = "danger";
            //btnEliminar.Disabled = false;
            //btnEliminar.EvtOnClick = "deleteActividad()";

            //btnActualizar.Value = "Actualizar";
            //btnActualizar.ButtonType = "warning";
            //btnActualizar.Disabled = false;
            //btnActualizar.EvtOnClick = "updateActividad()";

            uiContainer.UpdateModel(txtId);
            uiContainer.UpdateModel(txtNombre);
            uiContainer.UpdateModel(txtDescripcion);
            //uiContainer.UpdateModel(btnGuardar);
            //uiContainer.UpdateModel(btnEliminar);
            //uiContainer.UpdateModel(btnActualizar);

            return uiContainer;
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


    }
}