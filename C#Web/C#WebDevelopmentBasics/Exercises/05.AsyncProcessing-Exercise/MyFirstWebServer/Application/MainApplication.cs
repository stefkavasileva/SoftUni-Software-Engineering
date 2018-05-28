using MyFirstWebServer.Application.Controllers;
using MyFirstWebServer.Server.Handlers;
using MyFirstWebServer.Server.Routing.Contracts;
using MyFirstWebServer.Server.Contracts;

namespace MyFirstWebServer.Application
{
    public class MainApplication : IApplication
    {
        public void Start(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.AddRoute("/", new GetHandler(httpRerequest => new HomeController().Index()));

            appRouteConfig.AddRoute(
                "/register",
                new PostHandler(httpRerequest => new UserControllers()
                .RegisterPost(httpRerequest.FormData["name"])));

            appRouteConfig.AddRoute(
                "/register",
                new GetHandler(httpRerequest => new UserControllers().RegisterGet()));

            appRouteConfig.AddRoute(
                "/user/{(?<name>[a-z]+)}",
                new GetHandler(httpRerequest => new UserControllers()
                .Details(httpRerequest.UrlParameters["name"])));
        }
    }
}
