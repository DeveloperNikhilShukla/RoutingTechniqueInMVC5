using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingTechniqueinMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

       //    routes.MapRoute(
       //    name: "AllStudent",
       //    url: "student",
       //    defaults: new { controller = "Home", action = "GetStudent", id = UrlParameter.Optional }
       //);

       //     routes.MapRoute(
       //      name: "SingleStudent",
       //      url: "student/{id}",
       //      defaults: new { controller = "Home", action = "GetSingleStudent", id = UrlParameter.Optional }
       //  );
       //     routes.MapRoute(
       //        name: "StudentAddress",
       //        url: "student/{id}/address",
       //        defaults: new { controller = "Home", action = "GetStudentaddress", id = UrlParameter.Optional },
       //        constraints: new {id=@"\d+"}



        //   );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
             ]
            );
        }
    }
}
