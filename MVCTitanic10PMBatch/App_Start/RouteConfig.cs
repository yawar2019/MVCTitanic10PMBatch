using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTitanic10PMBatch
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//1)conventional based routing 2)Attribute based routing

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
           name: "Default1",
           url: "Hotel/Biryani",
           defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
       );

            routes.MapRoute(
              name: "Default2",
              url: "hospital/Biryani",
              defaults: new { controller = "Default", action = "SendData", id = UrlParameter.Optional }
          );


            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

        

           
        }
    }
}
