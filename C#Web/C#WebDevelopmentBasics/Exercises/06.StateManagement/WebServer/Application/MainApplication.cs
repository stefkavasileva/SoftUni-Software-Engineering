using HTTPServer.Server.Contracts;
using HTTPServer.Server.Routing.Contracts;
using HTTPServer.Application.Controllers;
using HTTPServer.Server.Enums;
using HTTPServer.Server.Handlers;

namespace HTTPServer.Application
{
    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get("/", httpRerequest => new HomeController().Index());
            //appRouteConfig.AddRoute("/", HttpRequestMethod.Get, new RequestHandler(req => new HomeController().Index()));
        }
    }
}
