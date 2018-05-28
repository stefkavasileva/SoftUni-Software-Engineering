using MyFirstWebServer.Server.HTTP.Contracts;
using System;
using System.Collections.Generic;

namespace MyFirstWebServer.Server.HTTP
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, HttpHeader>();
        }

        public void Add(HttpHeader header)
        {
            if (!this.headers.ContainsKey(header.Key))
            {
                this.headers.Add(header.Key, header);
                return;
            }

            this.headers[header.Key] = header;
        }

        public bool ContainsKey(string key)
        {
            return this.headers.ContainsKey(key);
        }

        public HttpHeader GetHeader(string key)
        {
            if (!this.headers.ContainsKey(key))
            {
                throw new InvalidOperationException("Headers collection does not contains a given key.");
            }

            return this.headers[key];
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.headers);
        }
    }
}
