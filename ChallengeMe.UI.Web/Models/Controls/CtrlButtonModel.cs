using System.Web.Script.Serialization;
using Newtonsoft.Json;
using ChallengeMe.UI.Web.Models.Controls;

namespace ChallengeMe.UI.Web.Models.Controls
{
    public class CtrlButtonModel : CtrlBaseModel
    {
        // Inputs del html, campos de texto
        private const string JS_FUNCTION_NAME = "BuildCtrlButton";

        //Atributos
        [JsonProperty]
        public string ButtonType { get; set; }

        [JsonProperty]
        public string Value { get; set; }

        [JsonProperty]
        public string EvtOnClick { get; set; }

        [JsonProperty]
        public bool Disabled { get; set; }

        public CtrlButtonModel()
        {
            JsFunctionName = JS_FUNCTION_NAME;
        }

        public CtrlButtonModel(string id, string value, string buttonType, string evtOnClick, bool disabled) : base(JS_FUNCTION_NAME, id, CtrlBaseModel.CType.CtrlButton)
        {
            JsFunctionName = JS_FUNCTION_NAME;
            Id = id;
            ButtonType = buttonType;
            Value = value;
            EvtOnClick = evtOnClick;
            Disabled = disabled;
        }

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
    }
}