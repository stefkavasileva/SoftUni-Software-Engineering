using MyFirstWebServer.Server.Contracts;
using System;

namespace MyFirstWebServer.Application.Vews
{
    public class AboutView : IView
    {
        public string View()
        {
            return "<h>Test about page</h1>";
        }
    }
}
