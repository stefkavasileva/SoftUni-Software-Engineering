using MyFirstWebServer.Server.Enums;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.HTTP.Contracts
{
    public interface IHttpRequest
    {
        Dictionary<string, string> FormData { get; }

        HttpHeaderCollection HttpHeaderCollection { get; }

        string Path { get; }

        Dictionary<string, string> QueryParameters { get; }

        HttpRequestMethod RequestMethod { get; }

        string Url { get; }

        Dictionary<string, string> UrlParameters { get; }

        void AddUrlParameters(string key, string value);
    }
}
