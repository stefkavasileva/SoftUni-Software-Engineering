using System.Linq;
using FDMC.App.Models.BindingModels;
using FDMC.Models;
using SimpleMvc.Common;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace FDMC.App.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public IActionResult Register() => this.View();

        [HttpPost]
        public IActionResult Register(UserRegisterBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                ShowError(model);
                return this.View();
            }

            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

            using (this.Context)
            {
                var user = new User
                {
                    Username = model.Username,
                    Password = passwordHash,
                    Email = model.Email,
                };

                this.Context.Users.Add(user);
                this.Context.SaveChanges();
                this.SignIn(user.Username, user.Id);
            }

            return this.RedirectToHome();
        }

        [HttpGet]
        public IActionResult Login() => this.View();

        [HttpPost]
        public IActionResult Login(UserLoginBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = "Invalid username and/or password";

                if (string.IsNullOrWhiteSpace(model.Username))
                {
                    this.Model.Data["error"] = "Username is required";
                }
                else if (string.IsNullOrWhiteSpace(model.Password))
                {
                    this.Model.Data["error"] = "Password is required";
                }

                return this.View();
            }

            if (this.User.IsAuthenticated)
            {
                return this.RedirectToHome();
            }

            using (this.Context)
            {
                var user = this.Context.Users.FirstOrDefault(u => u.Username == model.Username);
                if (user == null)
                {
                    this.Model.Data["error"] = "Invalid username and/or password";
                    return this.View();
                }

                var passwordHash = PasswordUtilities.GetPasswordHash(model.Password);

                if (user.Password != passwordHash)
                {
                    this.Model.Data["error"] = "Invalid username and/or password";
                    return this.View();
                }

                this.SignIn(user.Username, user.Id);
            }

            return RedirectToHome();
        }


        private void ShowError(UserRegisterBindingModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Username))
            {
                this.Model.Data["error"] = "Username is required";
            }
            else if (string.IsNullOrWhiteSpace(model.Email))
            {
                this.Model.Data["error"] = "Email is required";
            }
            else if (string.IsNullOrWhiteSpace(model.Password))
            {
                this.Model.Data["error"] = "Password is required";
            }
            else if (string.IsNullOrWhiteSpace(model.ConfirmPassword))
            {
                this.Model.Data["error"] = "Confirm password fild is required";
            }
            else if (model.Username.Length < 5)
            {
                this.Model.Data["error"] = "Username must be at least 5 cheracters long";
            }
            else if (model.Password.Length < 6)
            {
                this.Model.Data["error"] = "Password must be at least 6 cheracters long";
            }
            else if (model.Password != model.ConfirmPassword)
            {
                this.Model.Data["error"] = "Password do not match";
            }
        }
    }
}
