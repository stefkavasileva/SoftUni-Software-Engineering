
namespace KittenApp.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if (this.User.IsAuthenticated)
            {
                this.Model.Data["homeContent"] = 
                    $@"<div class=""jumbotron"">
                        <h1>Welcome, {this.User.Name}</h1>
                        <p>Fluffy Duffy Munchkin Cats wishes you a cute and awesome experience.</p>
                    </div>";
            }
            else
            {
                this.Model.Data["homeContent"] = 
                    $@"<div class=""jumbotron"">
                        <h1>Welcome to Fluffy Duffy Munchkin Cats</h1>
                        <p>The simplest, cutest, most reliable website for trading cats.</p>
                        <hr class=""my-2"">
                        <p><a href=""/users/login"">Login</a> to trade or <a href=""/users/register"">Register</a> if you don't have an account.</p>
                    </div>";
            }

            return this.View();
        }
    }
}
