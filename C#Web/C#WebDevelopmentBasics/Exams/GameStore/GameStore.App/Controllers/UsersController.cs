using GameStore.App.Models.Users;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Contracts;
using SimpleMvc.Framework.Controllers;

namespace GameStore.App.Controllers
{
    public class UsersController : Controller
    {
        //GET method for register, just return view with that name
        public IActionResult Register() => View();

        //POST method for register, accept viewmodel and save data in db
        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            return View();
        }

    }
}
