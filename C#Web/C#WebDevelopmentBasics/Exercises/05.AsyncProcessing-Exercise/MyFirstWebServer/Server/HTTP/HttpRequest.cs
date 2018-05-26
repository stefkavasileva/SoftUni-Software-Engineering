using System;
using System.Collections.Generic;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.HTTP.Contracts;
using MyFirstWebServer.Server.Exeptions;
using System.Net;

namespace MyFirstWebServer.Server.HTTP
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string requestString)
        {
            this.HttpHeaderCollection = new HttpHeaderCollection();
            this.UrlParameters = new Dictionary<string, string>();
            this.QueryParameters = new Dictionary<string, string>();
            this.FormFata = new Dictionary<string, string>();

            this.ParseRequest(requestString);
        }

        public HttpRequest()
        {
        }

        public Dictionary<string, string> FormFata { get; }

        public HttpHeaderCollection HttpHeaderCollection { get; }

        public string Path { get; private set; }

        public Dictionary<string, string> QueryParameters { get; }

        public HttpRequestMethod RequestMethod { get; private set; }

        public string Url { get; private set; }

        public Dictionary<string, string> UrlParameters { get; }

        public void AddUrlParameters(string key, string value)
        {
            if (!this.UrlParameters.ContainsKey(key))
            {
                this.UrlParameters.Add(key, value);
                return;
            }

            this.UrlParameters[key] = value;
        }

        private void ParseRequest(string requestString)
        {
            var requestLines = requestString.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var requestLine = requestLines[0].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (requestLine.Length != 3 || requestLine[2].ToLower() != "http/1.1")
            {
                throw new BadRequestException("Invalid request line.");
            }

            this.RequestMethod = this.ParseRequestMethod(requestLine[0].ToUpper());
            this.Url = requestLine[1];
            this.Path = this.Url.Split(new char[] { '?', '#' }, StringSplitOptions.RemoveEmptyEntries)[0];
            this.ParseHeader(requestLines);
            this.ParseParameters();

            if (this.RequestMethod == HttpRequestMethod.POST)
            {
                this.ParseQuery(requestLines[requestLines.Length - 1], this.FormFata);
            }


        }

        private void ParseParameters()
        {
            if (!this.Url.Contains("?"))
            {
                return;
            }

            var query = this.Url.Split("?")[1];
            this.ParseQuery(query, this.QueryParameters);
        }

        private void ParseQuery(string query, Dictionary<string, string> queryParameters)
        {
            if (!query.Contains("="))
            {
                return;
            }

            var queryPairs = query.Split("%");
            foreach (var queryPair in queryPairs)
            {
                var queryArgs = queryPair.Split("=");
                if (queryArgs.Length != 2)
                {
                    continue;
                }

                var key = queryArgs[0];
                var value = queryArgs[1];

                queryParameters.Add(WebUtility.UrlDecode(key), WebUtility.UrlDecode(value));
            }
        }

        private void ParseHeader(string[] requestLines)
        {
            var endIndex = Array.IndexOf(requestLines, string.Empty);

            for (int i = 1; i < endIndex; i++)
            {
                var headerArgs = requestLines[i].Split(new[] { ": " }, StringSplitOptions.None);
                if (headerArgs.Length != 2 || string.IsNullOrWhiteSpace(headerArgs[0]) || string.IsNullOrWhiteSpace(headerArgs[1]))
                {
                    throw new BadRequestException("Header must not be a empty string");
                }

                this.HttpHeaderCollection.Add(new HttpHeader(headerArgs[0], headerArgs[1]));
            }

            if (!this.HttpHeaderCollection.ContainsKey("Host"))
            {
                throw new BadRequestException("Invalid request.");
            }
        }

        private HttpRequestMethod ParseRequestMethod(string requestName)
        {
            HttpRequestMethod requestMethod;
            try
            {
                requestMethod = (HttpRequestMethod)Enum.Parse(typeof(HttpRequestMethod), requestName);
                return requestMethod;

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Invalid method type.");
            }
        }
    }
}
