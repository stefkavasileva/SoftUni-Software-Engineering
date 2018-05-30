using MyFirstWebServer.Server.Enums;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.Routing.Contracts
{
    public interface IServerRouteConfig
    {
        IDictionary<HttpRequestMethod, IDictionary<string, IRoutingContext>> Routes { get; }
    }
}
