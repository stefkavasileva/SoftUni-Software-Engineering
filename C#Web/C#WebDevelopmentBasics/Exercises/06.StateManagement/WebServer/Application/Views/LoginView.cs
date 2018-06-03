using HTTPServer.Server.Contracts;
using System;
using System.IO;

namespace HTTPServer.Application.Views
{
    public class LoginView : IView
    {
        public const string UsernameAndPasswordReq = "Username and password are required field!";
        private const string ColorKeyword = @"<!--color-->";
        private const string MessageKeyword = @"<!--message-->";

        private string color;
        private string message;

        public LoginView()
        {
        }

        public LoginView(string color, string message)
        {
            this.color = color;
            this.message = message;
        }

        public string View()
        {
            var html = string.Join(Environment.NewLine, File.ReadAllLines(@"../../../Application/Resources/login.html"));

            if (color != null && message != null)
            {
                html = html.Replace(ColorKeyword, this.color);
                html = html.Replace(MessageKeyword, this.message);
            }

            return html;
        }
    }
}