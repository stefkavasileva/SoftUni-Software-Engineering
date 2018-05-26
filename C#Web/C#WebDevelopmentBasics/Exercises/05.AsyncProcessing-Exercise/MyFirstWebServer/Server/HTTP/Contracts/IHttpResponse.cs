using MyFirstWebServer.Server.Enums;

namespace MyFirstWebServer.Server.HTTP.Contracts
{
    public interface IHttpResponse
    {
        HttpHeaderCollection HeaderCollection { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string StatusMessage { get; }

        void AddHeaders(string location, string redirectUrl);

        string Response { get; }

    }
}
