using HTTPServer.Application.Views;
using HTTPServer.Server.Enums;
using HTTPServer.Server.Http.Contracts;
using HTTPServer.Server.Http.Response;

namespace HTTPServer.Application.Controllers
{
    public class CakeController
    {
        //GET => add cake
        public IHttpResponse AddCakeGet()
        {
            return new ViewResponse(HttpStatusCode.Ok, new AddCakeView());
        }

        //POST => add cake
        public IHttpResponse AddCakePost(string name, decimal price)
        {
           
            return new RedirectResponse($"/add/{name}{price}");
        }
    }
}
