using HTTPServer.Server.Contracts;
using HTTPServer.Server.Routing.Contracts;
using HTTPServer.Application.Controllers;

namespace HTTPServer.Application
{
    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            //appRouteConfig.AddRoute("/", HttpRequestMethod.Get, new RequestHandler(req => new HomeController().Index()));
            appRouteConfig.Get("/", httpRerequest => new HomeController().Index());

            appRouteConfig.Get("/about", httpRerequest => new HomeController().About());

            appRouteConfig.Get("/add", httpRequest => new CakeController().AddCakeGet());
            appRouteConfig.Post("/add", httpRequest => new CakeController().AddCakePost(httpRequest.FormData["name"], decimal.Parse(httpRequest.FormData["price"])));

            appRouteConfig.Get("/search", httpRequest => new CakeController().SearchCakeGet(httpRequest));

            appRouteConfig.Get("/login", httpRequest => new UserController().Login());

            appRouteConfig.Post("/login", httpRequest => new UserController().LoginPost(httpRequest));
        }
    }
}
