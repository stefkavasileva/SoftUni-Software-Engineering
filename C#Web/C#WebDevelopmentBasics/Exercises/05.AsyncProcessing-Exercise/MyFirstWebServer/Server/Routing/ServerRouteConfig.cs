using System.Collections.Generic;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.Routing.Contracts;
using System;
using System.Linq;
using MyFirstWebServer.Server.Handlers;
using System.Text;
using System.Text.RegularExpressions;

namespace MyFirstWebServer.Server.Routing
{
    public class ServerRouteConfig : IServerRouteConfig
    {
        private readonly Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> routes;

        public ServerRouteConfig(IAppRouteConfig appRouteConfig)
        {
            this.routes = new Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>>();

            foreach (HttpRequestMethod requestMethod in Enum.GetValues(typeof(HttpRequestMethod)).Cast<HttpRequestMethod>())
            {
                this.routes.Add(requestMethod, new Dictionary<string, IRoutingContext>());
            }

            this.InitializeServerConfig(appRouteConfig);
        }

        private void InitializeServerConfig(IAppRouteConfig appRouteConfig)
        {
            foreach (KeyValuePair<HttpRequestMethod, Dictionary<string, RequestHandler>> kvp in appRouteConfig.Routes)
            {
                foreach (KeyValuePair<string, RequestHandler> requestHandler in kvp.Value)
                {
                    var args = new List<string>();

                    var parsedRegex = this.ParseRoute(requestHandler.Key, args);

                    IRoutingContext routingContext = new RoutingContext(requestHandler.Value, args);

                    this.Routes[kvp.Key].Add(parsedRegex, routingContext);
                }
            }
        }

        private string ParseRoute(string key, List<string> args)
        {
            var parsedRegex = new StringBuilder();
            parsedRegex.Append('^');

            if (key == "/")
            {
                parsedRegex.Append($"{key}$");
                return parsedRegex.ToString();
            }

            var tokens = key.Split("/");
            this.ParseTokens(args, tokens, parsedRegex);

            return parsedRegex.ToString();
        }

        private void ParseTokens(List<string> args, string[] tokens, StringBuilder parsedRegex)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                var end = i == tokens.Length - 1 ? "$" : "/";
                if (!tokens[i].StartsWith("{") && !tokens[i].EndsWith("}"))
                {
                    parsedRegex.Append($"{tokens[i]}{end}");
                    continue;
                }

                var pattern = "<\\w+>";
                var regex = new Regex(pattern);
                var match = regex.Match(tokens[i]);

                if (!match.Success)
                {
                    continue;
                }

                var paramName = match.Groups[0].Value.Substring(1, match.Groups[0].Length - 2);
                args.Add(paramName);
                parsedRegex.Append($"{tokens[i].Substring(1, tokens[i].Length - 2)}{end}");
            }
        }

        public Dictionary<HttpRequestMethod, Dictionary<string, IRoutingContext>> Routes => this.routes;
    }
}
