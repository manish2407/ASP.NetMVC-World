  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Employee",
            //    url: " Employee/Details/{id}",
            //    defaults: new { controller = "Employee", action = "Details" },
            //    constraints: new { id = @"\d+" }
            //);
            routes.MapRoute(
             "Default", // Route name
             "{controller}/{action}/{id}", // Route Pattern
             new { controller = "Employee", action = "Details", id = UrlParameter.Optional }, // Default values for parameters
             new { controller = "^E.*", action = "^Details$" } //Restriction for controller and action
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            
        }
    }
}
