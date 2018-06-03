using HTTPServer.Application.Views;
using HTTPServer.Server.Enums;
using HTTPServer.Server.Http.Contracts;
using HTTPServer.Server.Http.Response;
using HTTPServer.Server.Models;
using System.IO;
using System.Linq;

namespace HTTPServer.Application.Controllers
{
    public class CakeController
    {
        //GET => add cake
        public IHttpResponse AddCakeGet()
        {
            return new ViewResponse(HttpStatusCode.Ok, new AddCakeView());
        }

        //POST => add cake
        public IHttpResponse AddCakePost(string name, decimal price)
        {
            CakeList.Add(new Cake(name, price));

            File.WriteAllText("../../../Application/Resources/database.csv", CakeList.GetCakes());

            return new RedirectResponse($"/add");
        }

        //GET => search cake
        public IHttpResponse SearchCakeGet(IHttpRequest req)
        {
            string cakeName = string.Empty;

            if (req.UrlParameters.ContainsKey("search"))
            {
                cakeName = req.UrlParameters["search"];
            }

            return new ViewResponse(HttpStatusCode.Ok, new SearchView(cakeName));
        }

        
    }
}
