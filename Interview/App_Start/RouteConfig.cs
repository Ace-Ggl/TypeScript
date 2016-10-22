using System.Web.Mvc;
using System.Web.Routing;

namespace Interview
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AudiBrand",
                url: "Audi",
                defaults: new { controller = "Range", action = "List", name = "Audi" }
            );
            routes.MapRoute(
                name: "BMWBrand",
                url: "BMW",
                defaults: new { controller = "Range", action = "List", name = "BMW" }
            );
            routes.MapRoute(
                name: "FordBrand",
                url: "Ford",
                defaults: new { controller = "Range", action = "List", name = "Ford" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
