
function generarId() {
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");

    uiContainer.AddModel(txtId);

    AjaxAction("GenerarId", uiContainer, false);
}

function createPatrocinador() {
    alert("Creando patrocinador...");

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var tblPatrocinadores = new CtrlTableModel("tblPatrocinadores");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(tblPatrocinadores);

    AjaxAction("CreatePatrocinador", uiContainer, true);
}

function retrievePatrocinador() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("RetrievePatrocinador", uiContainer, false);
}

function retrieveAll() {

    var uiContainer = new UiContainer();
    var tblPatrocinadores = new CtrlTableModel("tblPatrocinadores");

    uiContainer.AddModel(tblPatrocinadores);

    AjaxAction("RetrieveAll", uiContainer, false);
}

function BindPatrocinadoresFields() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblPatrocinadores = new CtrlTableModel("tblPatrocinadores");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblPatrocinadores);

    AjaxAction("BindFields", uiContainer, false);
}

function updatePatrocinador() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var tblPatrocinadores = new CtrlTableModel("tblPatrocinadores");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(tblPatrocinadores);

    AjaxAction("UpdatePatrocinador", uiContainer, true);
}


function deletePatrocinador() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblPatrocinadores = new CtrlTableModel("tblPatrocinadores");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblPatrocinadores);

    AjaxAction("DeletePatrocinador", uiContainer, true);
}


function limpiarCampos() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var imgLogo = new CtrlImageModel("imgLogo");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(imgLogo);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("LimpiarCampos", uiContainer, false);
}

function volverAlInicio() {

    var uiContainer = new UiContainer();

    AjaxAction("VolverAlInicio", uiContainer, false);
}