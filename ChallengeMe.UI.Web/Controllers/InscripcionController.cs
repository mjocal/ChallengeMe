using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class InscripcionController : Controller
    {
        // GET: Inscripcion
        public ActionResult Inscripcion()
        {
            return View();
        }

    //    public UiContainer RetrieveAll(string objUiContainer)
    //    {
    //        var uiContainer = UiContainer.Build(objUiContainer);
    //        var tblInscripciones = uiContainer.GetCtrlModel<CtrlTableModel>("tblInscripciones");

    //        var mu = new InscripcionManagement();
    //        var list = mu.RetrieveAlls<Inscripcion>();

    //        tblInscripciones.RowList.Clear();

    //        foreach (var inscripcion in list)
    //        {
    //            if (inscripcion.Estado_Inscripcion.Equals("INACTIVO"))
    //            {

    //            }
    //            else
    //            {
    //                tblInscripciones.RowList.Add(new List<string>()
    //        {
    //            inscripcion.IdInscripcion.ToString(), inscripcion.NombreInscripcion, inscripcion.DescripcionInscripcion});
    //            }

    //        }

    //        uiContainer.UpdateModel(tblInscripciones);

    //        return uiContainer;
    //    }
    }
}