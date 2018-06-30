namespace WebServer.Http.Response
{
    using Enums;

    public class UnauthorizedResponse : HttpResponse
    {
        public UnauthorizedResponse(string message)
        {
            this.StatusCode = HttpStatusCode.Unauthorized;
            // TODO: Add message
        }
    }
}
