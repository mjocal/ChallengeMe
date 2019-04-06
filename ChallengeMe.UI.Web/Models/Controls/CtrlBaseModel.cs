using Newtonsoft.Json;
using System;

namespace ChallengeMe.UI.Web.Models.Controls
{
    public class CtrlBaseModel
    {
        //Control
        public enum CType { CtrlTable = 0, CtrlInput = 1, CtrlButton = 2, CtrlImage = 3, CtrlDropDown = 4 }

        // Atributos comunes para todos los controles
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string JsFunctionName { get; set; }

        [JsonProperty]
        public string ContainerId { get; set; }

        [JsonProperty]
        public string EncodedModel { get; set; }

        [JsonProperty]
        public CType CtrlType { get; set; }

        [JsonProperty]
        public bool UpdatedModel { get; set; }

        public CtrlBaseModel()
        {
            UpdatedModel = false;
        }


        protected CtrlBaseModel(string jsFunction, string id, CType ctrlType)
        {
            Id = id;
            JsFunctionName = jsFunction;
            ContainerId = "Ctrl_Container_" + Id;
            CtrlType = ctrlType;
            UpdatedModel = false;
        }

        public virtual string GetJsonModel()
        {
            return "";
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        // Esto sirve para codificar o descodificar el modelo correspondiente
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}