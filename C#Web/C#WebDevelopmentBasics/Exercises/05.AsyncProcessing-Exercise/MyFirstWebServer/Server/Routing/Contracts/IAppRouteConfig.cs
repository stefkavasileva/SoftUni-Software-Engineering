using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.Handlers;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        Dictionary<HttpRequestMethod, Dictionary<string, RequestHandler>> Routes { get; }

        void AddRoute(string route, RequestHandler httpHandler);
    }
}
