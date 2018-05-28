using MyFirstWebServer.Server.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstWebServer.Application.Vews
{
    class RegisterView : IView
    {
        public string View()
        {
            return "<body>" +
                "   <form method=\"POST\">" +
                "       Name<br/>" +
                "       <input type=\"text\" name=\"name\"/><br/>" +
                "       <input type=\"submit\"/>" +
                "   </form>" +
                "</body>";

        }
    }
}
