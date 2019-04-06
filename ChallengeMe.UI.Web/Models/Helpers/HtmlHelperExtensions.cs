using ChallengeMe.UI.Web.Models.Controls;
using System.Web;
using System.Web.Mvc;

namespace ChallengeMe.UI.Web.Models.Helpers
{
    // Metodo que nos permite desde la vista invocar este control

    public static class HtmlHelperExtensions
    {

        public static HtmlString CtrlInput(this HtmlHelper html, string id, string label, string type = "text", string placeholder = "", string value = "", bool required = false, bool disabled = false)
        {
            var ctrl = new CtrlInputModel(id, label, type, placeholder, value, required, disabled);

            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlButton(this HtmlHelper html, string id, string value, string buttonType = "info", string evtOnClick = "", bool disabled = false)
        {
            var ctrl = new CtrlButtonModel(id, value, buttonType, evtOnClick, disabled);

            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlTable(this HtmlHelper html, string id, string title, string columnHeaders, string onSelect)
        {
            var ctrl = new CtrlTableModel(id, title, columnHeaders, onSelect);

            return new HtmlString(ctrl.GetHtml());
        }

        public static HtmlString CtrlImage(this HtmlHelper html, string id, byte[] byteImage = default(byte[]), string height = "24", string width = "24", string imageType = "circle", string altText = "Logo del patrocinador ", bool disabled = false)
        {
            var ctrl = new CtrlImageModel(id, byteImage, imageType, altText, height, width, disabled);

            return new HtmlString(ctrl.GetHtml());
        }

        //public static HtmlString CtrlDropDown(this HtmlHelper html, string id, string label, string type = "text", string value = "", bool required = false, bool disabled = false)
        //{
        //    var ctrl = new CtrlDropDownModel(id, label, type, value, required, disabled);

        //    return new HtmlString(ctrl.GetHtml());
        //}




    }
}