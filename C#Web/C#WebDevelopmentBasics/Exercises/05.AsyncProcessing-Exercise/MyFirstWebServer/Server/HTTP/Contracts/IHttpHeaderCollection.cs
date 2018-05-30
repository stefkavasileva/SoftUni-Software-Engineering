using System.Collections.Generic;

namespace MyFirstWebServer.Server.HTTP.Contracts
{
    public interface IHttpHeaderCollection
    {
        void Add(HttpHeader header);

        bool ContainsKey(string key);

        ICollection<HttpHeader> GetHeader(string key);
    }
}
