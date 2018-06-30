namespace KittenApp.Web.Controllers
{
    using KittenApp.Data;
    using SimpleMvc.Framework.Controllers;
    using SimpleMvc.Framework.Interfaces;

    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            this.Context = new KittenAppContext();
        }
        
        protected KittenAppContext Context { get; set; }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/home/index");

        public override void OnAuthentication()
        {
            this.Model.Data["topMenu"] = this.User.IsAuthenticated ?
                @"<li class=""nav-item active"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/kittens/all"">All Kittens</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/kittens/add"">Add Kitten</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/users/logout"">Logout</a>
                </li>" :
                @"<li class=""nav-item active"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/users/login"">Login</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/users/register"">Register</a>
                </li>";

            base.OnAuthentication();
        }
    }
}
