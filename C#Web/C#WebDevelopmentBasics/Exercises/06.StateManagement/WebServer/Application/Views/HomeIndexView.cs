using HTTPServer.Server.Contracts;
using System;
using System.IO;

namespace HTTPServer.Application.Views
{
    class HomeIndexView : IView
    {
        public string View()
        {
            var html = string.Join(Environment.NewLine, File.ReadAllLines(@"../../../Application/Resources/index.html"));
            return html;
        }
    }
}
