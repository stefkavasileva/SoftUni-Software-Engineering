using MyFirstWebServer.Server.Routing.Contracts;

namespace MyFirstWebServer.Server.Contracts
{
    public interface IApplication
    {
        void Start(IAppRouteConfig appRouteConfig);
    }
}
