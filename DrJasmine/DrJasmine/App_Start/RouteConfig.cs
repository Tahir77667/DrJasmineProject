using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DrJasmine
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Home
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Main", action = "Home", id = UrlParameter.Optional }
            );

            //Home1
            routes.MapRoute(
                name: "Home1",
                url: "Home",
                defaults: new { controller = "Main", action = "Home", id = UrlParameter.Optional }
            );

            //About
            routes.MapRoute(
               name: "About",
               url: "About",
               defaults: new { controller = "Main", action = "About", id = UrlParameter.Optional }
            );

            //Services
            routes.MapRoute(
               name: "Services",
               url: "Services",
               defaults: new { controller = "Main", action = "Services", id = UrlParameter.Optional }
            );

            //Appointment
            routes.MapRoute(
                name: "Appointment",
                url: "Appointment",
                defaults: new { controller = "Main", action = "Appointment", id = UrlParameter.Optional }
            );

            //Contact
            routes.MapRoute(
                name: "Contact",
                url: "Contact",
                defaults: new { controller = "Main", action = "Contact", id = UrlParameter.Optional }
            );

            //Submit
            routes.MapRoute(
                name: "Submit",
                url: "Submit",
                defaults: new { controller = "Main", action = "Submit", id = UrlParameter.Optional }
            );

            //Blog
            routes.MapRoute(
                name: "Blog",
                url: "Blog",
                defaults: new { controller = "Main", action = "Blog", id = UrlParameter.Optional }
            );

            //Blog1
            routes.MapRoute(
                name: "Blog1",
                url: "Blog1",
                defaults: new { controller = "Main", action = "Blog1", id = UrlParameter.Optional }
            );

            //Blog2
            routes.MapRoute(
                name: "Blog2",
                url: "Blog2",
                defaults: new { controller = "Main", action = "Blog2", id = UrlParameter.Optional }
            );

            //Admin
            routes.MapRoute(
                name: "Admin",
                url: "Admin",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
             );


            //Default
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Main", action = "Home", id = UrlParameter.Optional }
            );



        }
    }
}
