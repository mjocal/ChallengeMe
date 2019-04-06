using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Perfil()
        {
            return View();
        }
    }
}