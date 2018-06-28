using System.Linq;
using MeTube.App.Models.BindingModels;
using MeTube.Models;
using SimpleMvc.Common;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace MeTube.App.Controllers
{
    public class UsersController : BaseController
    {
        private const string InvalidUsernameOrPasswordMessage = "Invalid username and/or password";

        [HttpGet]
        public IActionResult Register()
        {
            if (!this.User.IsAuthenticated)
            {
                this.RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Register(UserRegisterBindingModel user)
        {
            if (!this.IsValidModel(user))
            {
                this.Model.Data["error"] = this.GetErrorMessageFromInfalidProp(user);
                return this.View();
            }

            if (!this.User.IsAuthenticated)
            {
                this.RedirectToHome();
            }

            var userDb = new User
            {
                Username = user.Username,
                Email = user.Email,
                Password = PasswordUtilities.GetPasswordHash(user.Password)
            };

            using (this.Context)
            {
                this.Context.Users.Add(userDb);
                this.Context.SaveChanges();
            }

            this.SignIn(userDb.Username);
            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginBindingModel user)
        {
            if (this.User.IsAuthenticated)
            {
                return RedirectToHome();
            }

            if (!this.IsValidModel(user))
            {
                this.Model.Data["error"] = InvalidUsernameOrPasswordMessage;
                return this.View();
            }

            User userDb;
            using (this.Context)
            {
                userDb = this.Context.Users.Where(u => u.Username == user.Username).FirstOrDefault();
            }

            if (userDb is null)
            {
                this.Model.Data["error"] = InvalidUsernameOrPasswordMessage;
                return this.View();
            }

            var passwordHash = PasswordUtilities.GetPasswordHash(user.Password);

            if (passwordHash != userDb.Password)
            {
                this.Model.Data["error"] = InvalidUsernameOrPasswordMessage;
                return this.View();
            }

            this.SignIn(userDb.Username);
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
