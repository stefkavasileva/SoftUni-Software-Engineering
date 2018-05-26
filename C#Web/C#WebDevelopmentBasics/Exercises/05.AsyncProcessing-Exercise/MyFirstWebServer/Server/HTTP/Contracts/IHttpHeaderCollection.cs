namespace MyFirstWebServer.Server.HTTP.Contracts
{
    public interface IHttpHeaderCollection
    {
        void Add(HttpHeader header);

        bool ContainsKey(string key);

        HttpHeader GetHeader(string key);
    }
}
