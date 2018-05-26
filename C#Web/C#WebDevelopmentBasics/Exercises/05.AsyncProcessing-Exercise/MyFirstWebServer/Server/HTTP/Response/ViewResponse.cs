using MyFirstWebServer.Server.Contracts;
using MyFirstWebServer.Server.Enums;

namespace MyFirstWebServer.Server.HTTP.Response
{
    public class ViewResponse : HttpResponse
    {
        public ViewResponse(HttpStatusCode responseCode, IView view) 
            : base(responseCode, view)
        {
        }
    }
}
