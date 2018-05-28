using MyFirstWebServer.Server.Contracts;

namespace MyFirstWebServer.Application.Vews
{
    public class NotFoundView : IView
    {
        public string View()
        {
            return "<h>Page not found</h>";
        }
    }
}
