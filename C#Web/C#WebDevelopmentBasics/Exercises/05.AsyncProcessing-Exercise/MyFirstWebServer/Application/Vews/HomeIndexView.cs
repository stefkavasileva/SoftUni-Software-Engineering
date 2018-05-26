using MyFirstWebServer.Server.Contracts;

namespace MyFirstWebServer.Application.Vews
{
    public class HomeIndexView : IView
    {
        public string View()
        {
            return "<body><h1>Welcome</h1></body>";
        }
    }
}
