using FDMC.Data;
using FDMC.Models;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;

namespace FDMC.App.Controllers
{
    public class BaseController : Controller
    {
        protected BaseController()
        {
            this.Context = new FDMCContext();
            this.Model.Data["error"] = string.Empty;
        }

        protected FDMCContext Context { get; }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/home/index");


    }
}
