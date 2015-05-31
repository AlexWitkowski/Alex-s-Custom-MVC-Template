using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCTemplate.Classes
{
    public static class HtmlHelpers
    {
        //IsActive Custom HTML Helper used for highlighting the navbar location
        public static string IsActive(this HtmlHelper html,
                              string control,
                              string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control == routeControl &&
                               action == routeAction;

            return returnActive ? "nav-active" : "";
        }
    }
}
