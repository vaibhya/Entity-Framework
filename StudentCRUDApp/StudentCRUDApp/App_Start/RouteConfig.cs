﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StudentCRUDApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Home", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Add",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Add", id = UrlParameter.Optional }
            );
        }
    }
}