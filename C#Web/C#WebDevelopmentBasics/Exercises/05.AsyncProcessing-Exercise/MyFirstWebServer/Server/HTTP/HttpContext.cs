using HTTPServer.Server.Http;
using MyFirstWebServer.Server.HTTP.Contracts;

namespace MyFirstWebServer.Server.HTTP
{
    public class HttpContext : IHttpContext
    {
        private readonly IHttpRequest request;

        public HttpContext(string requestStr)
        {
            this.request = new HttpRequest(requestStr);
        }

        public IHttpRequest Request => this.request;
    }
}
