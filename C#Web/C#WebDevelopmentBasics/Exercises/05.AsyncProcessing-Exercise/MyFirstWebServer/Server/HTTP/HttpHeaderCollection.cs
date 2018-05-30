using MyFirstWebServer.Server.HTTP.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyFirstWebServer.Server.HTTP
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, ICollection<HttpHeader>> headers;

        public HttpHeaderCollection()
        {
            this.headers = new Dictionary<string, ICollection<HttpHeader>>();
        }

        public void Add(HttpHeader header)
        {
            if (!this.headers.ContainsKey(header.Key))
            {
                this.headers[header.Key] = new List<HttpHeader>();
            }

            this.headers[header.Key].Add(header);
        }

        public void Add(string key, string value)
        {
            this.Add(new HttpHeader(key, value));
        }

        public bool ContainsKey(string key)
        {
            return this.headers.ContainsKey(key);
        }

        public ICollection<HttpHeader>  GetHeader(string key)
        {
            if (!this.headers.ContainsKey(key))
            {
                throw new InvalidOperationException("Headers collection does not contains a given key.");
            }

            return this.headers[key];
        }

        public IEnumerator<ICollection<HttpHeader>> GetEnumerator()
              => this.headers.Values.GetEnumerator();

         //IEnumerator IEnumerable.GetEnumerator()
         //   => this.headers.Values.GetEnumerator();

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var header in this.headers)
            {
                var headerKey = header.Key;

                foreach (var headerValue in header.Value)
                {
                    result.AppendLine($"{headerKey}: {headerValue.Value}");
                }
            }

            return result.ToString();
        }
    }
}
