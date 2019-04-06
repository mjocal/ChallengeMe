
function BuildCtrlImage(encodedModel) {

    var disabledText = '';
    var model = jQuery.parseJSON($.base64.decode(encodedModel));
    var id = model.Id;
    var byteImage = model.ByteImage;
    var altText = model.AltText;
    var height = model.Height;
    var width = model.Width;
    var imageType = model.ImageType;
    var imageStyle = "img-" + imageType;

    if (model.Disabled) {
        disabledText = "disabled";
    }

    //Generacion del html
    var htmlText = '<img id="' + id + '" class="' + imageStyle + '" src = "data:image/png;base64," "' + byteImage + '" alt="' + altText +
                   '" height="' + height +'" width = "' + width +'" />';

    // Linea de JQuery, para hacer una seleccion en el documento utilizando el ID
    $('#' + model.ContainerId).html(htmlText);

    //Setea los atributos custom postPintado
    SetAttributteValue(id, "ImageType", model.ImageType);
    //SetControlValue(id, model.disabledText);
    SetAttributteValue(id, "ContainerId", model.ContainerId);
    SetAttributteValue(id, "JsFunctionName", model.JsFunctionName);
    SetAttributteValue(id, "CtrlType", model.CtrlType);
}

function CtrlImageModel(id) {
    this.id = id;
    this.ImageType = GetAttributteValue(id, "ImageType");
    this.AltText = GetAttributteValue(id, "AltText");
    this.ByteImage = GetAttributteValue(id, "ByteImage");
    this.Height = GetAttributteValue(id, "Height");
    this.Width = GetAttributteValue(id, "Width");
    //this.buttonType = GetAttributteValue(id, "ButtonType");
    //this.disabledText = GetControlValue(id);
    //this.Value = GetControlValue(id);
    this.ContainerId = GetAttributteValue(id, "ContainerId");
    this.JsFunctionName = GetAttributteValue(id, "JsFunctionName");
    this.CtrlType = GetAttributteValue(id, "CtrlType");
}