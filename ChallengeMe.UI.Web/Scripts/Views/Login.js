function iniciarSesion() {

    
    var uiContainer = new UiContainer();
    var txtCedula = new CtrlInputModel("txtCedula");
    var txtClave = new CtrlInputModel("txtClave");
    
   


    uiContainer.AddModel(txtCedula);
    uiContainer.AddModel(txtClave);
   
  

    AjaxAction("InicioDeSesion", uiContainer, true);


}