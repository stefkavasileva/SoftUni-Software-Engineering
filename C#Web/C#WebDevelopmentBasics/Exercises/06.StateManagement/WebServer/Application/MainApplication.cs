using HTTPServer.Server.Contracts;
using HTTPServer.Server.Routing.Contracts;
using HTTPServer.Application.Controllers;

namespace HTTPServer.Application
{
    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get("/", httpRerequest => new HomeController().Index());
            appRouteConfig.Get("/about", httpRerequest => new HomeController().About());
            //appRouteConfig.AddRoute("/", HttpRequestMethod.Get, new RequestHandler(req => new HomeController().Index()));
        }
    }
}
