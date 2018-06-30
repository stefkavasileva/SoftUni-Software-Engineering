using System.Linq;
using SimpleMvc.Common;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;
using TicketSystem.App.Models.BindingModels;
using TicketSystem.Models;

namespace TicketSystem.App.Controllers
{
    public class UserController : BaseController
    {
        [HttpGet]
        public IActionResult Register()
        {
            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterBindingModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = this.GetErrorMessageFromInvalidProp(model);
                return this.View();
            }

            var userDb = new User
            {
                Email = model.Email,
                Name = model.Name,
                Password = PasswordUtilities.GetPasswordHash(model.Password)
            };

            using (this.Context)
            {
                if (!this.Context.Users.Any())
                {
                    userDb.IsAdmin = true;
                }

                this.Context.Users.Add(userDb);
                this.Context.SaveChanges();
            }

            this.SignIn(userDb.Name, userDb.Id);
            return RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginBindingModel model)
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = this.GetErrorMessageFromInvalidProp(model);
                return this.View();
            }

            User userDb;
            using (this.Context)
            {
                userDb = this.Context.Users.FirstOrDefault(u => u.Email == model.Email);
            }

            if (userDb is null)
            {
                this.Model.Data["error"] = "Invalid username or/and password";
                return this.View();
            }

            var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);
            if (passwordHash != userDb.Password)
            {
                this.Model.Data["error"] = "Invalid username or/and password";
                return this.View();
            }

            this.SignIn(userDb.Name,userDb.Id);
            return RedirectToHome();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            this.SignOut();
            return RedirectToHome();
        }
    }
}
