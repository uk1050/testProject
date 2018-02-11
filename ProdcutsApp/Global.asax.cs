using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ProdcutsApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Web API ルート
            RouteTable.Routes.MapHttpRoute(
                name: "search",
                routeTemplate: "api/search/",
                defaults: new { controller = "prodcuts", action = "Search" }
            );

            RouteTable.Routes.MapHttpRoute(
                name: "search2",
                routeTemplate: "api/search2/",
                defaults: new { controller = "search", action = "Search" }
            );

            RouteTable.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
