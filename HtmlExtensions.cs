using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RemoteEmpoyeeManagementSystem.Helpers

{

    public static class HtmlExtensions
    {
        public static IHtmlContent DisabledIf(this IHtmlHelper html,bool condition)
        {
            //string str = string.Empty;
            //if(!string.IsNullOrEmpty(Convert.ToString(CheckIn)) && string.IsNullOrEmpty(Convert.ToString(CheckOut)))
            //    {
            //    str = "hidden=\"hidden\"";
            //}
            //else if(!string.IsNullOrEmpty(Convert.ToString(CheckIn)) && !string.IsNullOrEmpty(Convert.ToString(CheckOut)))
            //{
            //    str = "";
            //}
            //else 
            //{ 
            //    str = "";
            //}
            //return new HtmlString(str);
            //return new HtmlString(!string.IsNullOrEmpty(Convert.ToString(CheckIn)) && string.IsNullOrEmpty(Convert.ToString(CheckOut)) ? "hidden=\"hidden\"" :
            //    !string.IsNullOrEmpty(Convert.ToString(CheckIn)) && !string.IsNullOrEmpty(Convert.ToString(CheckOut)) ? "" :"");   //"hidden=\"hidden\""
            return new HtmlString(condition? "hidden=\"hidden\"":"");
        }
    }

}
