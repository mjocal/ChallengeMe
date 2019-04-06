using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace ChallengeMe.UI.Web.Models.Controls
{
    public class CtrlInputModel : CtrlBaseModel
    {
        // Inputs del html, campos de texto
        private const string JS_FUNCTION_NAME = "BuildCtrlInput";

        //Atributos
        [JsonProperty]
        public string Label { get; set; }

        [JsonProperty]
        public string Value { get; set; }

        [JsonProperty]
        public string IType { get; set; }

        [JsonProperty]
        public string PlaceHolder { get; set; }

       

        [JsonProperty]
        public bool Required { get; set; }

        [JsonProperty]
        public bool Disabled { get; set; }

        public CtrlInputModel()
        {
            JsFunctionName = JS_FUNCTION_NAME;
        }

        public CtrlInputModel(string id, string label, string type, string placeholder, string value, bool required, bool disabled) : base(JS_FUNCTION_NAME, id, CType.CtrlInput)
        {
            JsFunctionName = JS_FUNCTION_NAME;
            Label = label;
            Id = id;
            IType = type;
            PlaceHolder = placeholder;
           
            Value = value;
            Required = required;
            Disabled = disabled;
        }

        // Devuelve el html del control
        // Los numeros entre corchetes van a ser reemplazados por un parametro 
        // Los reemplazos son ContainerId, JS_FUNCTION_NAME y GetJsonModel
        public string GetHtml()
        {
            var html = "<div id='{0}'>" + "<script>{1}('{2}')</script>" + "</div>";

            return string.Format(html, ContainerId, JS_FUNCTION_NAME,
                GetJsonModel());
        }

        // Serializa el objeto a un formato Json
        public override string GetJsonModel()
        {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(this);
            var jsonBase64 = Base64Encode(json);

            return jsonBase64;
        }

        public override string ToString()
        {
            var result = JsonConvert.SerializeObject(this);
            return result;
        }

        public void Clear()
        {
            Value = "";
        }
    }
}