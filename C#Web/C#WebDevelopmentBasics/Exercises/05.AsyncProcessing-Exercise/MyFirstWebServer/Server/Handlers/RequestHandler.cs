using MyFirstWebServer.Server.Handlers.Contracts;
using MyFirstWebServer.Server.HTTP.Contracts;
using System;

namespace MyFirstWebServer.Server.Handlers
{
    public abstract class RequestHandler : IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> func;

        public RequestHandler(Func<IHttpRequest, IHttpResponse> func)
        {
            this.func = func;
        }

        public IHttpResponse Handle(IHttpContext httpContext)
        {
            IHttpResponse httpResponse = this.func(httpContext.Request);

            httpResponse.AddHeaders("Content-Type", "text/html");

            return httpResponse;
        }
    }
}
