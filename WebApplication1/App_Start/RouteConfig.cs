using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Image",
               url: "Image",
               defaults: new { controller = "Home", action = "Image", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Index",
               url: "Index",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "About",
               url: "About",
               defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "Comment",
              url: "Comment",
              defaults: new { controller = "Home", action = "Comment", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
