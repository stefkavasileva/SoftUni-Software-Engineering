using MyFirstWebServer.Server.Handlers;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.Routing.Contracts
{
    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler RequestHandler { get; }
    }
}
