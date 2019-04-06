using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ChallengeMe.UI.Web.Controllers
{
    public class IniciarSesionController : Controller
    {
        [AllowAnonymous]
        // GET: IniciarSesion
        public ActionResult IniciarSesion()
        {
           
            return View();
        }
        [AllowAnonymous]
        public UiContainer InicioDeSesion(string objUiContainer)
        {
            var uiContainer = UiContainer.Build(objUiContainer);
            var managerDeUsuarios = new UserManagement();
            var usuarioWEB = new User();
            var managerDeRol = new RolManagement();
            var rolDB = new Rol();


            try
            {
                var txtCedula = uiContainer.GetCtrlModel<CtrlInputModel>("txtCedula");
                var txtClave = uiContainer.GetCtrlModel<CtrlInputModel>("txtClave");
                


                //Inicia el código de encriptación de la contraseña
                var ueCodigo = new UnicodeEncoding();
                //Objeto para instanciar las codificación
                var Md5 = new MD5CryptoServiceProvider();
                //Calcula el valor hash de la cadena recibida->txtPassw
                byte[] bHashU = Md5.ComputeHash(ueCodigo.GetBytes(txtClave.Value));

                //'se toma en codigo ya encriptado del password recibido en la caja de texto
                //'y se iguala a una variable llamada password que es la que va a ir a 
                //'guardarse a la BD
                var password = Convert.ToBase64String(bHashU);


                //SE IGUALA LA INSTANCIA DEL PASSWORD DEL USUARIO AL PASSWORD INTRODUCIDO DESDE EL FORM
                //PARA IR A HACER LA BUSCQUEDA EN LA TABLA A TRAVES DE ESE VALOR Y VERIFICAR SI LA CLAVE EXISTE
                //Y SI EXISTE, SI LA CLAVE PERTEN
                usuarioWEB.Pass_Usuario = password;
                usuarioWEB.IdUsuario = txtCedula.Value;

                //HACE LA BUSQUEDA EN LA BD, POR LO QUE VA A IR A PASAR POR TODA LA ARQUITECTURA
                usuarioWEB = managerDeUsuarios.Retrieve(usuarioWEB);


                //SI LA CLAVE NO EXISTE EN LA TABLA DE USUARIOS
                if (usuarioWEB == null)
                {
                    uiContainer.ErrorMessage = "El usuario " + txtCedula.Value + " aún no está registrado";
                }
                else
                {
                    //CASO CONTRARIO, SI EXISTE SE VERIFICA SI LA CLAVE QUE SE ENCONTRO EN ESE REGISTRO DE LA TABLA
                    //CONINCIDE CON LA CLAVE QUE EL USUARIO ESTÁ INGRESANDO POR TECLADO
                    //SI CONINCIDEN ENTONCES EL USUARIO ES VALIDO
                    var Clave = usuarioWEB.Pass_Usuario;

                    if (Clave == password)
                    {
                        var rol = usuarioWEB.IdRole;

                        rolDB.IdRol = rol;

                        rolDB = managerDeRol.Retrieve(rolDB);
                        //var uiContainer = UiContainer.Build(objUiContainer);

                        if (rolDB != null)
                        {
                            ViewBag.Rol = rolDB.Nombre_Role;
                        }


                        //return uiContainer;

                    }
                    else
                    {
                        uiContainer.ErrorMessage = "La contraseña introducida es incorrecta";
                    }
                }




            }
            catch (ChallengeMeException ex)
            {
                uiContainer.ErrorMessage = ex.ErrorDescription;
            }


            return uiContainer;
        }
    }
}