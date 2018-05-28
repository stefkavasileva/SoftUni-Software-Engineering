using MyFirstWebServer.Application.Vews;
using MyFirstWebServer.Server;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.HTTP.Contracts;
using MyFirstWebServer.Server.HTTP.Response;

namespace MyFirstWebServer.Application.Controllers
{
    public class UserControllers
    {
        public IHttpResponse RegisterGet()
        {
            return new ViewResponse(HttpStatusCode.OK, new RegisterView());
        }

        public IHttpResponse RegisterPost(string name)
        {
            return new RedirectResponse($"/user/{name}");
        }

        public IHttpResponse Details(string name)
        {
            var model = new Model { ["name"] = name };
            return new ViewResponse(HttpStatusCode.OK, new UserDetailsView(model));
        }
    }
}