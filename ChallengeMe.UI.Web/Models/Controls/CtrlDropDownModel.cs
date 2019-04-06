//using System.Collections.Generic;
//using System.Web.Script.Serialization;
//using Newtonsoft.Json;
//using ChallengeMe.UI.Web.Models.Controls;

//namespace ChallengeMe.UI.Web.Models.Controls
//{
//    [JsonObject(MemberSerialization.OptIn)]
//    public class CtrlDropDownModel : CtrlBaseModel
//    {
//        private const string JS_FUNCTION_NAME = "BuildCtrlDropDown";

//        [JsonProperty]
//        public string Name { get; set; }

//        [JsonProperty]
//        public string Value { get; set; }

//        [JsonProperty]
//        public List<List<string>> RowList { get; set; }

//        [JsonProperty]
//        public int SelectedRowIndex { get; set; }

//        [JsonProperty]
//        public string OnSelect { get; set; }

//        public CtrlDropDownModel()
//        {
//            JsFunctionName = JS_FUNCTION_NAME;
//        }

//        public CtrlDropDownModel(string id, string name, string value, string onSelect)
//            : base(JS_FUNCTION_NAME, id, CType.CtrlTable)
//        {
//            Id = id;
//            Name = name;
//            Value = value;
//            RowList = new List<List<string>>();
//            OnSelect = onSelect;
//        }

//        public string GetHtml()
//        {
//            var html = "<div id='{0}'>" + "<script>{1}('{2}')</script>" + "</div>";

//            return string.Format(html, ContainerId, JS_FUNCTION_NAME, GetJsonModel());
//        }

//        public override string GetJsonModel()
//        {
//            var serializer = new JavaScriptSerializer();
//            var json = serializer.Serialize(this);
//            var jsonBase64 = Base64Encode(json);

//            return jsonBase64;
//        }

//        public override string ToString()
//        {
//            var result = JsonConvert.SerializeObject(this);
//            return result;
//        }

//        public List<string> GetSelectedRow()
//        {
//            return RowList[SelectedRowIndex];
//        }
//    }
//}