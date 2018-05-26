using MyFirstWebServer.Application.Vews;
using MyFirstWebServer.Server.HTTP.Contracts;
using MyFirstWebServer.Server.HTTP.Response;
using MyFirstWebServer.Server.Enums;

namespace MyFirstWebServer.Application.Controllers
{
    public class HomeController
    {
        public IHttpResponse Index()
        {
            return new ViewResponse(HttpStatusCode.OK, new HomeIndexView());
        }
    }
}
