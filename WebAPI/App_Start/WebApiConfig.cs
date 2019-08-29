using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //()()Enable CORS
           // config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers:"*",methods:"*"));
            //config.EnableCors(new EnableCorsAttribute("http://ang7-dev1.ap-southeast-2.elasticbeanstalk.com", headers: "*", methods: "*"));
            // Web API configuration and services

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
