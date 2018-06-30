namespace SimpleMvc.Framework.Routers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using SimpleMvc.Common;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Attributes.Security;
    using SimpleMvc.Framework.Controllers;
    using SimpleMvc.Framework.Interfaces;
    using SimpleMvc.Framework.Validation;
    using WebServer.Contracts;
    using WebServer.Enums;
    using WebServer.Exceptions;
    using WebServer.Http.Contracts;
    using WebServer.Http.Response;

    public class ControllerRouter : IHandleable
    {
        private const string BasePath = "/";
        private const string DefaultControllerName = "HomeController";
        private const string DefaultActionName = "Index";

        public IHttpResponse Handle(IHttpRequest request)
        {
            var getParams = request.UrlParameters;
            var postParams = request.FormData;
            var requestMethod = request.Method.ToString();


            string controllerName = string.Empty;
            string actionName = string.Empty;

            if (request.Path == BasePath)
            {
                return new RedirectResponse("/home/index");
            }
            else
            {
                string[] invocationParameters =
                    request.Path.Split('/', StringSplitOptions.RemoveEmptyEntries);
                if (invocationParameters.Length != 2)
                {
                    throw new InvalidOperationException("Invalid URL");
                }

                controllerName = invocationParameters[0].CapitalizeFirstLetter() + MvcContext.Get.ControllerSuffix;
                actionName = invocationParameters[1].CapitalizeFirstLetter();
            }

            var controller = this.GetController(controllerName, request);

            try
            {
                MethodInfo action = this.GetMethod(requestMethod, controller, actionName);
                if (action == null)
                {
                    return new NotFoundResponse();
                }

                var authAttribute = action
                   .GetCustomAttributes()
                   .Where(attr => attr is PreAuthorizeAttribute)
                   .Cast<PreAuthorizeAttribute>()
                   .FirstOrDefault();
                if (authAttribute != null && !controller.User.IsAuthenticated)
                {
                    return authAttribute.GetResponse("The user is not authorized to perform this action.");
                }

                var parameterValidator = new ParameterValidator();
                var actionParameters = this.MapActionParameters(action, getParams, postParams, parameterValidator);
                controller.ParameterValidator = parameterValidator;
                return this.PrepareResponse(controller, action, actionParameters);
            }
            catch (UnauthorizedException e)
            {
                return new PreAuthorizeAttribute().GetResponse(e.Message);
            }
        }

        private IHttpResponse PrepareResponse(
            Controller controller,
            MethodInfo method,
            object[] parameters)
        {
            IActionResult actionResult = (IActionResult)method.Invoke(controller, parameters);
            string invocationResult = actionResult.Invoke();
            if (actionResult is IViewable)
            {
                return new ContentResponse(HttpStatusCode.Ok, invocationResult);
            }
            else if (actionResult is IRedirectable)
            {
                return new RedirectResponse(invocationResult);
            }
            else
            {
                throw new InvalidOperationException("The view result is not supported.");
            }
        }


        private object[] MapActionParameters(
            MethodInfo method,
            IDictionary<string, string> getParams,
            IDictionary<string, string> postParams,
            ParameterValidator parameterValidator)
        {
            var parameterDescriptions = method.GetParameters();
            object[] parameters = new object[parameterDescriptions.Length];
            for (int index = 0; index < parameterDescriptions.Length; index++)
            {
                var param = parameterDescriptions[index];
                if (param.ParameterType.IsPrimitive || param.ParameterType == typeof(string))
                {
                    // GET request -> primitive types only
                    parameters[index] = ProcessPrimitiveParameter(getParams, param);
                }
                else
                {
                    // POST request -> models
                    parameters[index] = ProcessBindingModelParameters(postParams, param, parameterValidator);
                }
            }

            return parameters;
        }

        private Controller GetController(string controllerName, IHttpRequest request)
        {
            string controllerTypeName = string.Format(
                "{0}.{1}.{2}, {0}",
                MvcContext.Get.AssemblyName,
                MvcContext.Get.ControllersFolder,
                controllerName);

            var controllerType = Type.GetType(controllerTypeName);
            if (controllerName == null)
            {
                return null;
            }

            var controller = (Controller)Activator.CreateInstance(controllerType);
            if (controller != null)
            {
                controller.Request = request;
                controller.SetAuthentication();
                controller.OnAuthentication();
            }

            return controller;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods(Controller controller, string actionName)
        {
            if (controller == null)
            {
                return new MethodInfo[0];
            }

            return controller
                .GetType()
                .GetMethods()
                .Where(methodInfo => methodInfo.Name.ToLower() == actionName.ToLower());
        }

        private MethodInfo GetMethod(
            string requestMethod,
            Controller controller,
            string actionName)
        {
            MethodInfo method = null;
            foreach (var methodInfo in this.GetSuitableMethods(controller, actionName))
            {
                IEnumerable<HttpMethodAttribute> attributes = methodInfo
                    .GetCustomAttributes()
                    .Where(attr => attr is HttpMethodAttribute)
                    .Cast<HttpMethodAttribute>();

                if (!attributes.Any() && requestMethod.ToUpper() == "GET")
                {
                    return methodInfo;
                }

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(requestMethod))
                    {
                        return methodInfo;
                    }
                }

            }

            return method;
        }

        private static object ProcessPrimitiveParameter(
            IDictionary<string, string> getParams,
            ParameterInfo param)
        {
            object value = getParams[param.Name];
            return Convert.ChangeType(value, param.ParameterType);
        }

        private static object ProcessBindingModelParameters(
            IDictionary<string, string> postParams,
            ParameterInfo param,
            ParameterValidator parameterValidator)
        {
            Type modelType = param.ParameterType;
            var modelInstance = Activator.CreateInstance(modelType);
            var modelProperties = modelType.GetProperties();
            foreach (var property in modelProperties)
            {
                try
                {
                    var value = postParams[property.Name];
                    property.SetValue(modelInstance, Convert.ChangeType(value, property.PropertyType));
                }
                catch(Exception)
                {
                    parameterValidator.AddModelError(property.Name, $"The {property.Name} field could not be mapped.");
                }
            }

            return Convert.ChangeType(modelInstance, modelType);
        }
    }
}
