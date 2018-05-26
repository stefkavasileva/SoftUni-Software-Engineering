using System;
using MyFirstWebServer.Server.HTTP.Contracts;

namespace MyFirstWebServer.Server.Handlers
{
    public class GetHandler : RequestHandler
    {
        public GetHandler(Func<IHttpRequest, IHttpResponse> func) 
            : base(func)
        {
        }
    }
}
