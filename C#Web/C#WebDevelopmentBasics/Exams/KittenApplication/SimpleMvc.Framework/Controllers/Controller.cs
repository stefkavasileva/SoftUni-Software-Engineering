namespace SimpleMvc.Framework.Controllers
{
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using SimpleMvc.Framework.ActionResults;
    using SimpleMvc.Framework.Interfaces;
    using SimpleMvc.Framework.Models;
    using SimpleMvc.Framework.Security;
    using SimpleMvc.Framework.Validation;
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

        public Authentication User { get; set; }

        public IHttpRequest Request { get; set; }

        public ParameterValidator ParameterValidator { get; set; }

        protected IViewable View([CallerMemberName] string caller = "")
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

            bool errorFound = false;

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
                        this.ParameterValidator.AddModelError(
                            property.Name,
                            validationResult.ErrorMessage
                                .Replace(bindingModel.GetType().Name, property.Name));
                        errorFound = true;
                    }
                }
            }

            return !errorFound;
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

        protected void SignIn(string username, int userId)
        {
            this.Request.Session.Add(SessionStore.CurrentUserKey, username);
            this.Request.Session.Add(SessionStore.CurrentUserIdKey, userId);
        }

        protected void SignOut()
        {
            this.Request.Session.Clear();
        }

        public virtual void OnAuthentication()
        {
            // If a child controller needs to implement this lifecycle method,
            // they will simply override it
        }
    }
}
