﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Wedding_management_project.Common;
using Wedding_management_project.Models;

namespace Wedding_management_project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index",  id = UrlParameter.Optional },
                namespaces: new string[] { "Wedding_management_project.Controllers" }
            );   

        }
    }
}
