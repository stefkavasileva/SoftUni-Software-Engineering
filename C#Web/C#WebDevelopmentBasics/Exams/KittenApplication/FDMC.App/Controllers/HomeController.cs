using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace FDMC.App.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (this.User.IsAuthenticated)
            {
                this.Model.Data["message"] = $@"<h1>Welcome, {this.User.Name}</h1>
                <hr>
                <p>Fluffy Duffy Munchkin Cats wishes you a cute and awesome experience</p>
                ";
            }
            else
            {
                this.Model.Data["message"] = @"
                    <h1>Welcome to Fluffy Duffy Munchkin Cats</h1>
                    <p>The simplest, cutest, most reliable website for trading cats.</p>
                    <hr class=""my-2"">
                    <p><a href =""users/login"">Login</a>to trade or<a href=""users/register"">Register</a> if you don't have an account.
                    </p>";
            }

            return this.View();
        }
    }
}


