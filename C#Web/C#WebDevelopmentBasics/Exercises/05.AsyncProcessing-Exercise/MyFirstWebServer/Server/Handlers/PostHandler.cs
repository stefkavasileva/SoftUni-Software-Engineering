using System;
using MyFirstWebServer.Server.HTTP.Contracts;

namespace MyFirstWebServer.Server.Handlers
{
    public class PostHandler : RequestHandler
    {
        public PostHandler(Func<IHttpRequest, IHttpResponse> func)
            : base(func)
        {
        }
    }
}
