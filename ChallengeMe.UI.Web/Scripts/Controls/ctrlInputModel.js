
function BuildCtrlInput(encodedModel) {

    var classInput = 'form-group';
    var requiredText = '';
    var disabledText = '';

    var model = jQuery.parseJSON($.base64.decode(encodedModel));
    var id = model.Id;
    var label = model.Label;
    var type = model.IType;
    var placeHolder = model.PlaceHolder;
  

    if (model.Required) {
        requiredText = "required";
        label = model.Label;
    }

    if (model.Disabled) {
        disabledText = "disabled";
    }

    var htmlText = '<div class="' + classInput + '" id="dvInput_' + id + '"> ' +
        '<label class="control-label" for="inputDefault">' + label + '</label> ' +
        '<input type="' + type + '" placeholder ="' + placeHolder + '" class="form-control" id="' + id + '" value="' +
         model.Value + '" ' + requiredText + ' " " ' + disabledText + '" ' + '"> ' + '</div>';

    $('#' + model.ContainerId).html(htmlText);

    //Setea los atributos custom postPintado
  
    SetAttributteValue(id, "Label", model.Label);
    SetAttributteValue(id, "ContainerId", model.ContainerId);
    SetAttributteValue(id, "JsFunctionName", model.JsFunctionName);
    SetAttributteValue(id, "CtrlType", model.CtrlType);
    SetAttributteValue(id, "IType", type);
    
    SetControlValue(id, model.Value);
}

// Se puede crear un obj en JS con estos atributos.
// Deben ser los mismos del CTRLINPUT en C#
function CtrlInputModel(id) {
    this.Id = id;
    this.Label = GetAttributteValue(id, "Label");
    this.Value = GetControlValue(id);
    this.ContainerId = GetAttributteValue(id, "ContainerId");
    this.JsFunctionName = GetAttributteValue(id, "JsFunctionName");
    this.CtrlType = GetAttributteValue(id, "CtrlType");
    //this.placeHolder = GetAttributteValue(id, "PlaceHolder");
   
    this.type = GetAttributteValue(id, "IType");
    this.Required = GetNativeAttributteValue(id, "required");
}
