using System.Collections.Generic;
using MyFirstWebServer.Server.Handlers;
using MyFirstWebServer.Server.Routing.Contracts;

namespace MyFirstWebServer.Server.Routing
{
    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler handler, IEnumerable<string> parameters)
        {
            this.RequestHandler = handler;
            this.Parameters = parameters;
        }

        public IEnumerable<string> Parameters { get; private set; }

        public RequestHandler RequestHandler { get; private set; }
    }
}
