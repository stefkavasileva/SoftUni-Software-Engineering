using System.Collections.Generic;
using System.IO;
using System.Linq;
using SimpleMvc.Framework.Interfaces;

namespace SimpleMvc.Framework.Views
{
    public class View : IRenderable
    {
        public const string BaseLayoutFileName = "Layout";
        public const string ContentPlaceholder = "{{{content}}}";
        public const string PathPrefix = "../../../";
        public const string HtmlExtension = ".html";
        public const string LocalErrorPath = "\\SimpleMvc.Framework\\Errors\\Error.html";

        private readonly string fullyQualifiedTemplateName;
        private readonly IDictionary<string, string> viewData;

        public View(
            IDictionary<string, string> viewData,
            string fullyQualifiedTemplateName)
        {
            this.viewData = viewData;
            this.fullyQualifiedTemplateName = fullyQualifiedTemplateName;
        }

        public string Render()
        {
            var fullHtml = this.ReadFile();

            if (viewData.Any())
            {
                foreach (var parameter in viewData)
                {
                    fullHtml = fullHtml.Replace(
                        $"{{{{{{{parameter.Key}}}}}}}",
                        parameter.Value);
                }
            }

            return fullHtml;
        }

        private string ReadFile()
        {
            var layoutHtml = this.RenderLayoutHtml();

            string templateFullyQualifiedNameWithExtension = 
               $"{PathPrefix}{this.fullyQualifiedTemplateName}{HtmlExtension}";

            if (!File.Exists(templateFullyQualifiedNameWithExtension))
            {
                var errorHtmlPath = this.GetErrorPath();
                var errorHtml = File.ReadAllText(errorHtmlPath);

                this.viewData.Add("error", "Requested view does no exist!");
                return errorHtml;
            }

            var templateHtml = File.ReadAllText(templateFullyQualifiedNameWithExtension);
            var fullHtml = layoutHtml.Replace(ContentPlaceholder, templateHtml);

            return fullHtml;
        }

        private string GetErrorPath()
        {
            var applicationDirectory = Directory.GetCurrentDirectory();
            var parentDirectory = Directory.GetParent(applicationDirectory);
            var parentDirectoryFullPath = parentDirectory.FullName;

            var errorPagePath = parentDirectoryFullPath + LocalErrorPath;

            return errorPagePath;
        }

        private string RenderLayoutHtml()
        {
            string layoutHtmlFullyQualifiedName = string.Format(
                "{0}{1}/{2}{3}",
                PathPrefix,
                MvcContext.Get.ViewsFolder,
                BaseLayoutFileName,
                HtmlExtension);

            if (!File.Exists(layoutHtmlFullyQualifiedName))
            {
                var errorHtmlPath = this.GetErrorPath();
                var errorHtml = File.ReadAllText(errorHtmlPath);
                this.viewData.Add("error", "Layout view does no exist!");
                return errorHtml;
            }

            var layoutHtml = File.ReadAllText(layoutHtmlFullyQualifiedName);
            return layoutHtml;
        }
    }
}
