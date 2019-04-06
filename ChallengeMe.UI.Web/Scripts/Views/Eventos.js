//Los JS de los views no se incorporan en el layout, sino en el
//view del archivo que lo estaria utilizando



function retrieveAll() {

    var uiContainer = new UiContainer();
    var tblEventos = new CtrlTableModel("tblEventos");

    uiContainer.AddModel(tblEventos);

    AjaxAction("RetrieveAll", uiContainer, false);
}

//Binding fields
function BindActividadesFields() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    //var btnGuardar = new CtrlButtonModel("btnGuardar");
    //var btnEliminar = new CtrlButtonModel("btnEliminar");
    //var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblEventos = new CtrlTableModel("tblEventos");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    //uiContainer.AddModel(btnGuardar);
    //uiContainer.AddModel(btnEliminar);
    //uiContainer.AddModel(btnActualizar);
    //uiContainer.AddModel(tblActividades);

    AjaxAction("BindFields", uiContainer, false);
}