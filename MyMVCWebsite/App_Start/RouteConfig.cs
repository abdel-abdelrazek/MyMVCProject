using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyMVCWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // To enable Attributes Routes 
            routes.MapMvcAttributeRoutes();


            // Without Attribute Routes
            //routes.MapRoute(
            //   "MoviesByReleaseDate",
            //   "Movies/Released/{year}/{month}",
            //   new { controller = "Movies", action = "ReleasedDate" },
            //   new { year =@"\d{4}", month=@"\d{2}"}// Regular Experession
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
