using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
   [AllowAnonymous]
    public class EventoController : Controller
    {
        
        
        public ActionResult Evento()
        {
            return View("Eventos");
            //GenerarId();
        }

        //public void GenerarId()
        //{
        //    int cod;
        //    //var mu = new CrudActividad();
        //    var mu = new ActividadManagement();
        //    var actividad = new Actividad();
        //    //var listaId = mu.RetrieveAllActividades<Actividad>();
        //    var listaId = mu.RetrieveAllActividades<Actividad>();
        //    var uiContainer = UiContainer.Build(objUiContainer);
        //    var txtId = uiContainer.GetCtrlModel<CtrlInputModel>("txtId");

        //    foreach (var u in listaId)
        //    {
        //        IdActividad = Convert.ToInt32(txtId.Value) + (u+1);
        //    }

        //    for (int j = 0; j < listaId.Count; j++)
        //    {

        //    }

        //    For i = 0 To listaId.Count - 1 
        //    If (listaId.Item(i).Estado_Actividad = "INACTIVO") Then
        //        Cod = listaId.Item(i).IdActividad
        //    Else
        //        Cod = listaId.Item(i).IdActividad
        //    End If

        //        Next

        //    txtIdActividad.Text = Cod + 1 
        //        txtIdActividad.Enabled = False
        //    txtNombreActividad.Focus
        //}



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


    }
}