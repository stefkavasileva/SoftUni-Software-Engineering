using MyFirstWebServer.Server.HTTP.Contracts;

namespace MyFirstWebServer.Server.Handlers.Contracts
{
    public interface IRequestHandler
    {
        IHttpResponse Handle(IHttpContext httpContext);
    }
}
