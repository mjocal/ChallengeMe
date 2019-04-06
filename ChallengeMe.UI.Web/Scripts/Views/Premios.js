
function generarId() {
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");

    uiContainer.AddModel(txtId);

    AjaxAction("GenerarId", uiContainer, false);
}

function createPremio() {
    alert("Creando premio...");

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var tblPremios = new CtrlTableModel("tblPremios");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(tblPremios);

    AjaxAction("CreatePremio", uiContainer, true);
}

function retrievePremio() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("RetrievePremio", uiContainer, false);
}

function retrieveAll() {

    var uiContainer = new UiContainer();
    var tblPremios = new CtrlTableModel("tblPremios");

    uiContainer.AddModel(tblPremios);

    AjaxAction("RetrieveAll", uiContainer, false);
}

function BindPremiosFields() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblPremios = new CtrlTableModel("tblPremios");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblPremios);

    AjaxAction("BindFields", uiContainer, false);
}

function updatePremio() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var tblPremios = new CtrlTableModel("tblPremios");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(tblPremios);

    AjaxAction("UpdatePremio", uiContainer, true);
}


function deletePremio() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblPremios = new CtrlTableModel("tblPremios");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblPremios);

    AjaxAction("DeletePremio", uiContainer, true);
}


function limpiarCampos() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("LimpiarCampos", uiContainer, false);
}

function volverAlInicio() {

    var uiContainer = new UiContainer();

    AjaxAction("VolverAlInicio", uiContainer, false);
}