using System.Collections.Generic;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.Handlers;
using MyFirstWebServer.Server.Routing.Contracts;
using System;
using System.Linq;

namespace MyFirstWebServer.Server.Routing
{
    public class AppRouteConfig : IAppRouteConfig
    {
        private readonly Dictionary<HttpRequestMethod, Dictionary<string, RequestHandler>> routes;

        public Dictionary<HttpRequestMethod, Dictionary<string, RequestHandler>> Routes => this.routes;

        public AppRouteConfig()
        {
            this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, RequestHandler>>();

            foreach (HttpRequestMethod requestMethod in Enum.GetValues(typeof(HttpRequestMethod)).Cast<HttpRequestMethod>())
            {
                this.routes.Add(requestMethod, new Dictionary<string, RequestHandler>());
            }
        }

        public void AddRoute(string route, RequestHandler httpHandler)
        {
            if (httpHandler.GetType().ToString().ToLower().Contains("get"))
            {
                this.routes[HttpRequestMethod.GET].Add(route, httpHandler);
            }
            else if (httpHandler.GetType().ToString().ToLower().Contains("post"))
            {
                this.routes[HttpRequestMethod.POST].Add(route, httpHandler);
            }
        }
    }
}
