
using System.Drawing;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace ChallengeMe.UI.Web.Models.Controls
{
    public class CtrlImageModel : CtrlBaseModel
    {
        private const string JS_FUNCTION_NAME = "BuildCtrlImage";

        //Atributos
        [JsonProperty]
        public byte[] ByteImage { get; set; }

        public void SetByteImage(Image image)
        {
            ImageConverter converter = new ImageConverter();
            ByteImage = (byte[])converter.ConvertTo(image, typeof(byte[]));
        }

        [JsonProperty]
        public string ImageType { get; set; }

        [JsonProperty]
        public string AltText { get; set; }

        [JsonProperty]
        public string Height { get; set; }

        [JsonProperty]
        public string Width { get; set; }

        [JsonProperty]
        public bool Disabled { get; set; }

        public CtrlImageModel()
        {
            JsFunctionName = JS_FUNCTION_NAME;
        }

        public CtrlImageModel(string id, byte[] byteImage, string imageType, string altText, string height, string width, bool disabled) : base(JS_FUNCTION_NAME, id, CType.CtrlImage)
        {
            JsFunctionName = JS_FUNCTION_NAME;
            Id = id;
            ByteImage = byteImage;
            ImageType = imageType;
            AltText = altText;
            Height = height;
            Width = width;
            Disabled = disabled;
        }

        public string GetHtml()
        {
            var html = "<div id='{0}'>" + "<script>{1}('{2}')</script>" + "</div>";

            return string.Format(html, ContainerId, JS_FUNCTION_NAME,
                GetJsonModel());
        }

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