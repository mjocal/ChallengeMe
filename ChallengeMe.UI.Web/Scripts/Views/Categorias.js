
function generarId() {
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");

    uiContainer.AddModel(txtId);

    AjaxAction("GenerarId", uiContainer, false);
}

function createCategoria() {
    alert("Creando categoria...");

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var tblCategorias = new CtrlTableModel("tblCategorias");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(tblCategorias);

    AjaxAction("CreateCategoria", uiContainer, true);
}

function retrieveCategoria() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("RetrieveCategoria", uiContainer, false);
}

function retrieveAll() {

    var uiContainer = new UiContainer();
    var tblCategorias = new CtrlTableModel("tblCategorias");

    uiContainer.AddModel(tblCategorias);

    AjaxAction("RetrieveAll", uiContainer, false);
}

function BindCategoriasFields() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblCategorias = new CtrlTableModel("tblCategorias");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblCategorias);

    AjaxAction("BindFields", uiContainer, false);
}

function updateCategoria() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var tblCategorias = new CtrlTableModel("tblCategorias");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(tblCategorias);

    AjaxAction("UpdateCategoria", uiContainer, true);
}


function deleteCategoria() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblCategorias = new CtrlTableModel("tblCategorias");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblCategorias);

    AjaxAction("DeleteCategoria", uiContainer, true);
}


function limpiarCampos() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);

    AjaxAction("LimpiarCampos", uiContainer, false);
}

function volverAlInicio() {

    var uiContainer = new UiContainer();

    AjaxAction("VolverAlInicio", uiContainer, false);
}