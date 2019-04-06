using System.Collections.Generic;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace ChallengeMe.UI.Web.Models.Controls
{
    [JsonObject(MemberSerialization.OptIn)]
    public class UiContainer
    {
        [JsonProperty]
        public List<CtrlBaseModel> Models { get; set; }

        [JsonProperty]
        public string InformationMessage { get; set; }

        [JsonProperty]
        public string ErrorMessage { get; set; }

        [JsonProperty]
        public string RedirectTo { get; set; }

        //Build toma lo que se le envia del AJAX ACTION del BASE MODEL y forma un objeto de tipo UICONTAINER
        public static UiContainer Build(string jsonObj)
        {
            var objResult = JsonConvert.DeserializeObject<UiContainer>(jsonObj);

            return objResult;
        }

        public T GetCtrlModel<T>(string id)
        {
            var index = 0;

            var modelsTemp = Models;

            foreach (var model in Models)
            {
                if (model.Id.Equals(id))
                {
                    var jsonModel = CtrlBaseModel.Base64Decode(model.EncodedModel);

                    var serializer = new JavaScriptSerializer();
                    var ctrlModel = serializer.Deserialize<T>(jsonModel);

                    return ctrlModel;
                }

                index++;
            }

            return default(T);
        }

        public void UpdateModel(CtrlBaseModel newModel)
        {
            var index = 0;
            var modelsTemp = Models;
            newModel.EncodedModel = CtrlBaseModel.Base64Encode(newModel.ToString());
            newModel.UpdatedModel = true;

            foreach (var model in modelsTemp)
            {
                if (model.Id.Equals(newModel.Id))
                {
                    Models[index] = newModel;
                    return;
                }
                index++;
            }

        }

        public override string ToString()
        {
            var result = JsonConvert.SerializeObject(this);
            return result;
        }
    }
}