using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BrnoMvc1.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //   name: "Movies",
            //   url: "{controller}/{action}/{year}/{month}",
            //   defaults: new
            //   {
            //       //controller = "Movies",
            //       //action = "Released"
            //   },
            //   constraints: new // Regular expression
            //   {
            //       year = @"\d{4}", // year = @"2016 | 2017", 
            //       month = "\\d{2}" // /movies/released/2017/4 returns 404 NOT FOUND
            //   }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
