function createUsuario() {
    

    var uiContainer = new UiContainer();
    var txtEmail = new CtrlInputModel("txtEmail");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtClave = new CtrlInputModel("txtClave");
    var txtConfirmarClave = new CtrlInputModel("txtConfirmarClave");
    

    uiContainer.AddModel(txtEmail);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtClave);
    uiContainer.AddModel(txtConfirmarClave);
    
    AjaxAction("CreateUsuario", uiContainer, true);


}

//function updateUsuairo() {
//    var uiContainer = new UiContainer();
//    var txtCedula = new CtrlInputModel("txtCedula");
//    var txtNombre = new CtrlInputModel("txtNombre");
//    var txtClave = new CtrlInputModel("txtClave");
//    var txtConfirmarClave = new CtrlInputModel("txtConfirmarClave");
//    var tblUsuarios = new CtrlTableModel("tblUsuarios");

//    uiContainer.AddModel(txtCedula);
//    uiContainer.AddModel(txtNombre);
//    uiContainer.AddModel(txtClave);
//    uiContainer.AddModel(txtConfirmarClave);
//    uiContainer.AddModel(tblUsuarios);

//    AjaxAction("UpdateUsuario", uiContainer, true)

//}