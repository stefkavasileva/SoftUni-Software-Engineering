using MyFirstWebServer.Application.Controllers;
using MyFirstWebServer.Server.Contracts;
using MyFirstWebServer.Server.Handlers;
using MyFirstWebServer.Server.Routing.Contracts;

namespace MyFirstWebServer.Application
{
    public class MainApplication : IApplication
    {
        public void Start(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.AddRoute("/", new GetHandler(httpContext => new HomeController().Index()));
        }
    }
}
