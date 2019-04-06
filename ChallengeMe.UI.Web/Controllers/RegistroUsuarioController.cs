using Challengeme.ApiCore;
using Challengeme.Entities;
using ChallengeMe.UI.Web.Models.Controls;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ChallengeMe.UI.Web.Controllers
{
    [AllowAnonymous]
    public class RegistroUsuarioController : Controller
    {
        [AllowAnonymous]
        // GET: RegistroUsuario
        public ActionResult RegistroUsuario()
        {
            return View();
        }

        public UiContainer CreateUsuario(string objUiContainer)
        {
         
            var mu = new UserManagement();
          

            var uiContainer = UiContainer.Build(objUiContainer);
            try
            {
                var txtEmail = uiContainer.GetCtrlModel<CtrlInputModel>("txtEmail");
                var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
                var txtClave = uiContainer.GetCtrlModel<CtrlInputModel>("txtClave");
                var txtConfirmarClave = uiContainer.GetCtrlModel<CtrlInputModel>("txtConfirmarClave");
              
              
                if (txtClave.Value.Length < 6)
                {
                    
                    uiContainer.ErrorMessage = "La contraseña debe ser mayor a 6 caracteres ";
                    txtClave.Value = "";
                    txtConfirmarClave.Value = "";
                    txtClave.IType = "password";
                    txtConfirmarClave.IType = "password";
                    txtClave.PlaceHolder = "Password";
                    txtConfirmarClave.PlaceHolder = "Password";

                    uiContainer.UpdateModel(txtClave);
                    uiContainer.UpdateModel(txtConfirmarClave);
                }else
                {
                    //Inicia el código de encriptación de la contraseña
                    var ueCodigo = new UnicodeEncoding();
                    //Objeto para instanciar las codificación
                    var Md5 = new MD5CryptoServiceProvider();
                    //Calcula el valor hash de la cadena recibida->txtPassw
                    byte[] bHashU = Md5.ComputeHash(ueCodigo.GetBytes(txtClave.Value));
                    byte[] bHasD = Md5.ComputeHash(ueCodigo.GetBytes(txtConfirmarClave.Value));
                    //'se toma en codigo ya encriptado del password recibido en la caja de texto
                    //'y se iguala a una variable llamada password que es la que va a ir a 
                    //'guardarse a la BD
                    var password = Convert.ToBase64String(bHashU);
                    var confirmarPassword = Convert.ToBase64String(bHasD);



                    if (password != confirmarPassword)
                    {
                        uiContainer.ErrorMessage = "Las contraseñas no coinciden, favor revisar";
                        
                    }
                    else
                    {


                        //Aquí vamos a crear el usuario
                        var usuario = new User()
                        {
                            Correo_Usuario = txtEmail.Value,
                            NombreUsuario = txtNombre.Value,
                            Pass_Usuario = password,
                            IdRole = 3,
                            IdEntidad = "3",
                            FCreacion_Usuario = DateTime.Today,
                            FNac_Usuario = DateTime.Today,
                            IdUsuario = txtEmail.Value,
                            Imagen_Usuario = null,

                        };
                       


                            mu.CreateUser(usuario);

                        //vamos a limpiar los campos
                        uiContainer.InformationMessage = "Gracias por registrarse, bienvenido a la comunidad ChallengeMe..! ";

                        txtEmail.Value = "";
                        txtNombre.Value = "";
                        txtClave.Value = "";
                        txtConfirmarClave.Value = "";

                        txtClave.IType = "password";
                        txtConfirmarClave.IType = "password";


                        txtEmail.PlaceHolder = "Email";
                        txtNombre.PlaceHolder = "Nombre completo";
                        txtClave.PlaceHolder = "Password";
                        txtConfirmarClave.PlaceHolder = "Password";

                        uiContainer.UpdateModel(txtEmail);
                        uiContainer.UpdateModel(txtNombre);
                        uiContainer.UpdateModel(txtClave);
                        uiContainer.UpdateModel(txtConfirmarClave);
                        
                        

                    }
                }
            }
            catch (ChallengeMeException ex)
            {
                uiContainer.ErrorMessage = ex.ErrorDescription;

            }

            return uiContainer;
            
        }



        //public UiContainer UpdateUsuario(string objUiContainer)
        //{
        //    var uiContainer = UiContainer.Build(objUiContainer);
        //    var txtCedula = uiContainer.GetCtrlModel<CtrlInputModel>("txtCedula");
        //    var txtNombre = uiContainer.GetCtrlModel<CtrlInputModel>("txtNombre");
        //    var txtClave = uiContainer.GetCtrlModel<CtrlInputModel>("txtClave");
        //    var txtConfirmarClave = uiContainer.GetCtrlModel<CtrlInputModel>("txtConfirmarClave");
          
        //    var usuario = new User()
        //    {
        //        IdUsuario = txtCedula.Value,
        //        NombreUsuario = txtNombre.Value,
        //        Pass_Usuario = txtClave.Value,
        //        IdRole = 3,
        //        IdEntidad = "3",
        //    };
        //    var mu = new UserManagement();
        //    mu.Update(usuario);

        //    txtCedula.Value = "";
        //    txtNombre.Value = "";
        //    txtClave.Value = "";
        //    txtConfirmarClave.Value = "";


            
        //    uiContainer.UpdateModel(txtCedula);
        //    uiContainer.UpdateModel(txtNombre);

         



        //    uiContainer.InformationMessage = "Usuario Actualizado Satisfactoriamente..!";
        //    return uiContainer;
        //}

    }
}
