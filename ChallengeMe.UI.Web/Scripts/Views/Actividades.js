//Los JS de los views no se incorporan en el layout, sino en el
//view del archivo que lo estaria utilizando

//Funcion de prueba que al momento no esta en uso
function generarId(){
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");

    uiContainer.AddModel(txtId);

    AjaxAction("GenerarId", uiContainer, false);
}

function createActividad() {
    alert("Creando actividad...");

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var tblActividades = new CtrlTableModel("tblActividades");
    //var btnGuardar  = new CtrlButtonModel("btnGuardar");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(tblActividades);
    //uiContainer.AddModel(btnGuardar);

    //Recibe 3 parametros: Nombre de la accion, de quien recibe y la validacion
    AjaxAction("CreateActividad", uiContainer, true);

    //limpiarCampos();
}

function retrieveActividad() {
    //alert("Buscando usuario...");
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

    //Recibe 3 parametros: Nombre de la accion, de quien recibe y la validacion
    //la validacion la dejamos FALSE porque es una prueba
    AjaxAction("RetrieveActividad", uiContainer, false);
}

function retrieveAll() {

    var uiContainer = new UiContainer();
    var tblActividades = new CtrlTableModel("tblActividades");

    uiContainer.AddModel(tblActividades);

    AjaxAction("RetrieveAll", uiContainer, false);
}

//Binding fields
function BindActividadesFields() {

    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblActividades = new CtrlTableModel("tblActividades");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblActividades);

    AjaxAction("BindFields", uiContainer, false);
}

function updateActividad() {
    //alert("Actualizando actividad...");
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var tblActividades = new CtrlTableModel("tblActividades");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(tblActividades);

    //Recibe 3 parametros: Nombre de la accion, de quien recibe y la validacion
    AjaxAction("UpdateActividad", uiContainer, true);
}


function deleteActividad() {
    debugger;
    //alert("Eliminando actividad...");
    var uiContainer = new UiContainer();
    var txtId = new CtrlInputModel("txtId");
    var txtNombre = new CtrlInputModel("txtNombre");
    var txtDescripcion = new CtrlInputModel("txtDescripcion");
    var btnGuardar = new CtrlButtonModel("btnGuardar");
    var btnEliminar = new CtrlButtonModel("btnEliminar");
    var btnActualizar = new CtrlButtonModel("btnActualizar");
    var tblActividades = new CtrlTableModel("tblActividades");

    uiContainer.AddModel(txtId);
    uiContainer.AddModel(txtNombre);
    uiContainer.AddModel(txtDescripcion);
    uiContainer.AddModel(btnGuardar);
    uiContainer.AddModel(btnEliminar);
    uiContainer.AddModel(btnActualizar);
    uiContainer.AddModel(tblActividades);

    //Recibe 3 parametros: Nombre de la accion, de quien recibe y la validacion
    AjaxAction("DeleteActividad", uiContainer, true);

    //limpiarCampos();
}


function limpiarCampos() {
    //alert("Limpiando todos los campos...");
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

    //la validacion la dejamos FALSE porque es una prueba
    AjaxAction("LimpiarCampos", uiContainer, false);
}

function volverAlInicio() {

    var uiContainer = new UiContainer();

    AjaxAction("VolverAlInicio", uiContainer, false);
}