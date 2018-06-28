namespace SimpleMvc.Framework.Controllers
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using SimpleMvc.Framework.ActionResults;
    using SimpleMvc.Framework.Attributes.Property;
    using SimpleMvc.Framework.Interfaces;
    using SimpleMvc.Framework.Models;
    using SimpleMvc.Framework.Security;
    using SimpleMvc.Framework.Views;
    using WebServer.Http;
    using WebServer.Http.Contracts;

    public abstract class Controller
    {
        protected Controller()
        {
            this.Model = new ViewModel();
            this.User = new Authentication();
        }

        protected ViewModel Model { get; set; }

        protected Authentication User { get; set; }

        public IHttpRequest Request { get; set; }

        protected virtual IViewable View([CallerMemberName] string caller = "")
        {
            var controllerName = this.GetType()
                .Name
                .Replace(MvcContext.Get.ControllerSuffix, string.Empty);

            var fullyQualifiedName = string.Format(
                "{0}\\{1}\\{2}",
                MvcContext.Get.ViewsFolder,
                controllerName,
                caller);

            var view = new View(this.Model.Data, fullyQualifiedName);

            return new ViewResult(view);
        }

        protected IRedirectable RedirectToAction(string redirectUrl)
        {
            return new RedirectResult(redirectUrl);
        }

        protected bool IsValidModel(object bindingModel)
        {
            var properties = bindingModel.GetType().GetProperties();

            foreach (var property in properties)
            {
                var validationAttributes = property
                    .GetCustomAttributes(true)
                    .Where(ca => ca is ValidationAttribute);

                if (!validationAttributes.Any())
                {
                    continue;
                }

                foreach (ValidationAttribute validationAttribute in validationAttributes)
                {
                    object propertyValue = property.GetValue(bindingModel);
                    var validationResult = validationAttribute.GetValidationResult(propertyValue, new ValidationContext(bindingModel));
                    if (validationResult != ValidationResult.Success)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        protected internal void InitializeUser()
        {
            var user = this.Request.Session.Get<string>(SessionStore.CurrentUserKey);
            if (user != null)
            {
                this.User = new Authentication(user);
            }
            else
            {
                this.User = new Authentication();
            }
        }

        protected void SignIn(string username)
        {
            this.Request.Session.Add(SessionStore.CurrentUserKey, username);
        }

        protected void SignOut()
        {
            this.Request.Session.Clear();
        }
    }
}
