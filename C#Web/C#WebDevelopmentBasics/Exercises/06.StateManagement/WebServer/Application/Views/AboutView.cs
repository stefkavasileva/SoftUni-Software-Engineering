using HTTPServer.Server.Contracts;
using System;
using System.IO;

namespace HTTPServer.Application.Views
{
    public class AboutView : IView
    {
        public string View()
        {
            var html = string.Join(Environment.NewLine, File.ReadAllLines(@"../../../Application/Resources/about.html"));
            return html;
        }
    }
}
