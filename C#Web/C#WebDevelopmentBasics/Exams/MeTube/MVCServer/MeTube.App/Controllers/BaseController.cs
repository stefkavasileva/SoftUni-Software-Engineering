using System.ComponentModel.DataAnnotations;
using System.Linq;
using MeTube.Data;
using SimpleMvc.Framework.Controllers;
using SimpleMvc.Framework.Interfaces;

namespace MeTube.App.Controllers
{
    public class BaseController : Controller
    {

        protected BaseController()
        {
            this.Context = new MeTubeContext();
            this.Model.Data["error"] = string.Empty;
        }

        protected MeTubeContext Context { get; }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/home/index");

        protected IActionResult RedirectToLogin() => this.RedirectToAction("/users/login");

        protected string GetErrorMessageFromInfalidProp(object bindingModel)
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
