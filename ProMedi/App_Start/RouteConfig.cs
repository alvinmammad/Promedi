using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProMedi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                  name: "BlogURL",
                  url: "blogdetails/{slug}",
                  defaults: new { controller = "Blog", action = "BlogDetails", slug = UrlParameter.Optional },
                  namespaces: new[] { "ProMedi.Controllers" }
              );

            routes.MapRoute(
                  name: "DepartmentURL",
                  url: "department/{slug}",
                  defaults: new { controller = "Department", action = "Department", slug = UrlParameter.Optional },
                  namespaces: new[] { "ProMedi.Controllers" }

              );

            routes.MapRoute(
                  name: "DoctorURL",
                  url: "doctordetails/{slug}",
                  defaults: new { controller = "Doctor", action = "DoctorDetails", slug = UrlParameter.Optional },
                  namespaces: new[] { "ProMedi.Controllers" }

              );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "home", id = UrlParameter.Optional },
                  namespaces: new[] { "ProMedi.Controllers" }
            );
        }
    }
}
