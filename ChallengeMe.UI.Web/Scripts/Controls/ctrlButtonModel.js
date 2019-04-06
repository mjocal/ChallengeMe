
function BuildCtrlButton(encodedModel) {

    var disabledText = '';
    var model = jQuery.parseJSON($.base64.decode(encodedModel));
    var id = model.Id;
    var value = model.Value;
    var buttonType = model.ButtonType;
    var buttonStyle = "btn btn-" + buttonType;

    // evento que va a suceder al realizar una accion (click)
    // no pueden estar asociados a metodos estaticos
    var evtOnClick = model.EvtOnClick;

    if (model.Disabled) {
        disabledText = "disabled";
    }

    //Generacion del html
    var htmlText = '<a href="#" id="' + id + '" class="' + buttonStyle + '" onclick="' + evtOnClick + ' " " ' + disabledText + '>' + value + ' </a>';

    // Linea de JQuery, para hacer una seleccion en el documento utilizando el ID
    $('#' + model.ContainerId).html(htmlText);

    //Setea los atributos custom postPintado
    SetAttributteValue(id, "ButtonType", buttonType);
    SetAttributteValue(id, "EvtOnClick", evtOnClick);
    SetControlValue(id, model.disabledText);
    SetControlValue(id, model.value);
    SetAttributteValue(id, "ContainerId", model.ContainerId);
    SetAttributteValue(id, "JsFunctionName", model.JsFunctionName);
    SetAttributteValue(id, "CtrlType", model.CtrlType);
}

function CtrlButtonModel(id) {
    this.id = id;
    this.buttonType = GetAttributteValue(id, "ButtonType");
    this.disabledText = GetControlValue(id);
    this.Value = GetControlValue(id);
    this.ContainerId = GetAttributteValue(id, "ContainerId");
    this.JsFunctionName = GetAttributteValue(id, "JsFunctionName");
    this.CtrlType = GetAttributteValue(id, "CtrlType");
    this.EvtOnClick = GetAttributteValue(id, "EvtOnClick");
}