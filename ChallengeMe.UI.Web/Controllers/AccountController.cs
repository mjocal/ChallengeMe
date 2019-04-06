using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ChallengeMe.UI.Web.Models;
using Challengeme.ApiCore;
using Challengeme.Entities;
using System.Text;
using System.Security.Cryptography;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AccountController()
        {
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            var managerDeUsuarios = new UserManagement();
            var usuarioWEB = new User();
            var managerDeRol = new RolManagement();
            var rolDB = new Rol();

            var txtEmail = model.Email;
            var txtPassword = model.Password;


            //Inicia el código de encriptación de la contraseña
            var ueCodigo = new UnicodeEncoding();
            //Objeto para instanciar las codificación
            var Md5 = new MD5CryptoServiceProvider();
            //Calcula el valor hash de la cadena recibida->txtPassw
            byte[] bHashU = Md5.ComputeHash(ueCodigo.GetBytes(txtPassword));

            //'se toma en codigo ya encriptado del password recibido en la caja de texto
            //'y se iguala a una variable llamada password que es la que va a ir a 
            //'guardarse a la BD
            var Password = Convert.ToBase64String(bHashU);


            if (ModelState.IsValid)
            {

                //SE IGUALA LA INSTANCIA DEL PASSWORD DEL USUARIO AL PASSWORD INTRODUCIDO DESDE EL FORM
                //PARA IR A HACER LA BUSCQUEDA EN LA TABLA A TRAVES DE ESE VALOR Y VERIFICAR SI LA CLAVE EXISTE
                //Y SI EXISTE, SI LA CLAVE PERTEN
                usuarioWEB.Pass_Usuario = Password;
                usuarioWEB.Correo_Usuario = txtEmail;

                //HACE LA BUSQUEDA EN LA BD, POR LO QUE VA A IR A PASAR POR TODA LA ARQUITECTURA
                usuarioWEB = managerDeUsuarios.RetrieveByEmail(usuarioWEB);
                if (usuarioWEB != null)
                {
                    if (usuarioWEB.Correo_Usuario.Equals(txtEmail) && usuarioWEB.Pass_Usuario.Equals(Password))
                    {

                        var rol = usuarioWEB.IdRole;
                        rolDB.IdRol = rol;

                        rolDB = managerDeRol.Retrieve(rolDB);
                        if (rolDB.Nombre_Role.Equals("WEB"))
                        {
                            Session["Rol"] = rolDB.Nombre_Role;
                            Session["User"] = usuarioWEB.NombreUsuario;
                            Session["Email"] = usuarioWEB.Correo_Usuario;
                            return Redirect(returnUrl ?? Url.Action("Index", "Account"));
                        }


                    }


                    if (usuarioWEB.Correo_Usuario.Equals(txtEmail) && usuarioWEB.Pass_Usuario.Equals(Password))
                    {
                        var rol = usuarioWEB.IdRole;
                        rolDB.IdRol = rol;

                        rolDB = managerDeRol.Retrieve(rolDB);
                        if (rolDB.Nombre_Role.Equals("SA") || rolDB.Nombre_Role.Equals("ORGANIZADOR"))
                        {
                            Session["Rol"] = rolDB.Nombre_Role;
                            Session["User"] = usuarioWEB.NombreUsuario;
                            Session["Email"] = usuarioWEB.Correo_Usuario;
                        }
                        return Redirect(returnUrl ?? Url.Action("Index", "Account"));

                    }
                    else
                    {
                        ModelState.AddModelError("", "Nombre de usuario o Contraseña incorrecta");
                        return View();
                    }

                }else
                {
                    ModelState.AddModelError("", "El usuario " + txtEmail +  "  no está registrado");
                    return View();

                }            
                
               



            }
            else
            {
                return View();

            }


            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }
        //
        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            Session["Rol"] = null;
            return RedirectToAction("Index", "Account");
        }

        //
        // POST: /Account/ExternalLogin
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider
            return new ChallengeResult(provider, Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl }));
        }

        //
        // GET: /Account/ExternalLoginCallback
        [AllowAnonymous]
        public async Task<ActionResult> ExternalLoginCallback(string returnUrl)
        {
            var loginInfo = await AuthenticationManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("Login");
            }

            // Sign in the user with this external login provider if the user already has a login
            var result = await SignInManager.ExternalSignInAsync(loginInfo, isPersistent: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                case SignInStatus.LockedOut:
                    return View("Lockout");
                case SignInStatus.RequiresVerification:
                    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = false });
                case SignInStatus.Failure:
                default:
                    // If the user does not have an account, then prompt the user to create an account
                    ViewBag.ReturnUrl = returnUrl;
                    ViewBag.LoginProvider = loginInfo.Login.LoginProvider;
                    return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = loginInfo.Email });
            }
        }

        //
        // POST: /Account/ExternalLoginConfirmation
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Manage");
            }

            if (ModelState.IsValid)
            {
                // Get the information about the user from the external login provider
                var info = await AuthenticationManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    return View("ExternalLoginFailure");
                }
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                   
                };
                var result = await UserManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await UserManager.AddLoginAsync(user.Id, info.Login);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);
                        return RedirectToLocal(returnUrl);
                    }
                }
                AddErrors(result);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }
        //
        // GET: /Account/ExternalLoginFailure
        [AllowAnonymous]
        public ActionResult ExternalLoginFailure()
        {
            return View();
        }




        #region Helpers
        // Used for XSRF protection when adding external logins
        private const string XsrfKey = "XsrfId";

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        internal class ChallengeResult : HttpUnauthorizedResult
        {
            public ChallengeResult(string provider, string redirectUri)
                : this(provider, redirectUri, null)
            {
            }

            public ChallengeResult(string provider, string redirectUri, string userId)
            {
                LoginProvider = provider;
                RedirectUri = redirectUri;
                UserId = userId;
            }

            public string LoginProvider { get; set; }
            public string RedirectUri { get; set; }
            public string UserId { get; set; }

            public override void ExecuteResult(ControllerContext context)
            {
                var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
                if (UserId != null)
                {
                    properties.Dictionary[XsrfKey] = UserId;
                }
                context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            }
        }
        #endregion
    }
}