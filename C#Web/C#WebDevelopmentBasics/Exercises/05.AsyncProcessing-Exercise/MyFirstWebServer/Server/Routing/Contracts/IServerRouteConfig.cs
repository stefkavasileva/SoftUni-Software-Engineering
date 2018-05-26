using MyFirstWebServer.Server.Enums;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.Routing.Contracts
{
    public interface IServerRouteConfig
    {
        Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> Routes { get; }
    }
}
