using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CTITopicModelingAPI
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Register - Handling routing
        /// </summary>
        /// <param name="config"></param>
        public static void Register(HttpConfiguration config)
        {          
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
