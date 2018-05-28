using MyFirstWebServer.Application.Vews;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.HTTP.Response;

public class NotFoundResponse : ViewResponse
{
    public NotFoundResponse()
        : base(HttpStatusCode.NotFound, new NotFoundView())
    {
    }
}