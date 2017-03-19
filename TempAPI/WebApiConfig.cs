using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TempAPI
{
    public class WebApiConfig
    {
        //public static void Register(HttpConfiguration config)
        //{
        //    config.Routes.MapHttpRoute(
        //        name: "AllCustomersss",
        //        routeTemplate: "Customersss",
        //        defaults: new { controller = "Customers", action = "Get" }
        //        );
        //}

        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllCustomers",
                routeTemplate: "Accounts",
                defaults: new { controller = "Account", action = "Register" }
                );
        }
    }
}