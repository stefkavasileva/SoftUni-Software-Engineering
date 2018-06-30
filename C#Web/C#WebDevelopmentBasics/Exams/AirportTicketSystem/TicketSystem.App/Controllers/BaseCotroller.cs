using System.ComponentModel.DataAnnotations;
using System.Linq;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;
using TicketSystem.Data;

namespace TicketSystem.App.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController()
        {
            this.Context = new TicketSystemContext();
        }

        public override void OnAuthentication()
        {
            this.Model.Data["menu"] = this.User.IsAuthenticated ?
                $@"<nav>
                    <div class=""left-container"">
                        <ul>
                            <li><a href=""/flight/catalog"">Flights</a></li>
                            <li><a href=""/user/mytickets"">My Tickets</a></li>
                        </ul>
                     </div>
                    <div class=""right-container"">
                        <span>Welcome, {this.User.Name} |</span>
                        <a href=""/user/logaout"" class=""log-out"">Logout</a>
                        <a href=""/user/cart""><img src=""../Content/img/cart.jpg"" class=""cart""></a>
                     </div>
                </nav>" :
                @"<nav class=""nav-register""><div class=""left-container"">
                        <ul><li><a href=""/flight/all"">Flights</a></li>
                            <li><a href=""/user/login"">Login</a></li>
                            <li><a href=""/user/register"">Register</a></li>
                        </ul>
                    </div>
                </nav>";

            base.OnAuthentication();
        }

        protected TicketSystemContext Context { get; set; }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/flight/catalog");

        protected IActionResult RedirectToLogin() => this.RedirectToAction("/user/login");

        protected string GetErrorMessageFromInvalidProp(object bindingModel)
        {
            var properties = bindingModel.GetType().GetProperties().ToList();
            var errorMessage = string.Empty;
            foreach (var property in properties)
            {
                var validationAttributes = property
                    .GetCustomAttributes(true)
                    .Where(ca => ca is ValidationAttribute);

                foreach (ValidationAttribute validationAttribute in validationAttributes)
                {
                    object propertyValue = property.GetValue(bindingModel);
                    var validationResult = validationAttribute.GetValidationResult(propertyValue, new ValidationContext(bindingModel));
                    if (validationResult != ValidationResult.Success)
                    {
                        errorMessage = validationResult.ErrorMessage;
                        return errorMessage;
                    }
                }
            }

            return errorMessage;
        }
    }
}
