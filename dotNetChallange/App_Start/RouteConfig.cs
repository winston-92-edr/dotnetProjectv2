using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace dotNetChallange
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Last24hData",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Last24hData" }
            );

            routes.MapRoute(
                name: "Last7DayData",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Last7DayData" }
            );

            routes.MapRoute(
                name: "Last30DayData",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Last30DayData" }
            );

            routes.MapRoute(
                name: "Batch",
                url: "{controller}/{action}",
                defaults: new { controller = "Batch", action = "Index" }
            );
        }
    }
}
