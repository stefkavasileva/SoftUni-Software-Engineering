using MyFirstWebServer.Server.Handlers.Contracts;
using MyFirstWebServer.Server.HTTP.Contracts;
using MyFirstWebServer.Server.HTTP.Response;
using MyFirstWebServer.Server.Routing.Contracts;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyFirstWebServer.Server.Handlers
{
    public class HttpHandler : IRequestHandler
    {
        private readonly IServerRouteConfig serverRouteConfig;

        public HttpHandler(IServerRouteConfig serverRouteConfig)
        {
            this.serverRouteConfig = serverRouteConfig;
        }

        public IHttpResponse Handle(IHttpContext httpContext)
        {
            foreach (KeyValuePair<string,IRoutingContext> kvp in this.serverRouteConfig.Routes[httpContext.Request.RequestMethod])
            {
                var pattern = kvp.Key;
                var regex = new Regex(pattern);
                Match match = regex.Match(httpContext.Request.Path);

                if (!match.Success)
                {
                    continue;
                }

                foreach (var parameter in kvp.Value.Parameters)
                {
                    httpContext.Request.AddUrlParameters(parameter, match.Groups[parameter].Value);
                }

               return kvp.Value.RequestHandler.Handle(httpContext);
            }

            return new NotFoundResponse();
        }
    }
}
