using HTTPServer.Application.Views;
using HTTPServer.Server.Enums;
using HTTPServer.Server.Http;
using HTTPServer.Server.Http.Contracts;
using HTTPServer.Server.Http.Response;

namespace HTTPServer.Application.Controllers
{
    public class UserController
    {
        public IHttpResponse Login()
        {
            return new ViewResponse(HttpStatusCode.Ok, new LoginView());
        }

        public IHttpResponse LoginPost(IHttpRequest req)
        {
            if (
                (req.UrlParameters.ContainsKey("username") &&
                req.UrlParameters.ContainsKey("password"))
                &&
                (!string.IsNullOrEmpty(req.UrlParameters["username"].Trim()) &&
                !string.IsNullOrEmpty(req.UrlParameters["password"].Trim()))
                )
            {
                string username = req.UrlParameters["username"].Trim();
                string password = req.UrlParameters["password"].Trim();

                //Credentials Check ?

                req.Session.Add(SessionStore.SessionCookieKey, username);

                return new RedirectResponse("/");
            }
            else
            {
                return new ViewResponse(HttpStatusCode.Ok, new LoginView("Red", LoginView.UsernameAndPasswordReq));
            }
        }
    }
}
