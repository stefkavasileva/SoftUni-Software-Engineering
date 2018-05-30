using MyFirstWebServer.Server.Enums;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.HTTP.Contracts
{
    public interface IHttpRequest
    {
        IDictionary<string, string> FormData { get; }

        IHttpHeaderCollection Headers { get; }

        string Path { get; }

        IDictionary<string, string> QueryParameters { get; }

        HttpRequestMethod Method { get; }

        string Url { get; }

        IDictionary<string, string> UrlParameters { get; }

        void AddUrlParameter(string key, string value);
    }
}
