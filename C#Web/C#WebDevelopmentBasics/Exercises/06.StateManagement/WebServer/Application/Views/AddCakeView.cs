using HTTPServer.Server.Contracts;
using HTTPServer.Server.Models;
using System;
using System.IO;

namespace HTTPServer.Application.Views
{
    public class AddCakeView : IView
    {
        public string View()
        {
            //var cakesAsHtml = CakeList.GetCakesAsHtml();
            var html = string.Join(Environment.NewLine, File.ReadAllLines(@"../../../Application/Resources/add.html"));

           // html += cakesAsHtml;

            return html;
        }
    }
}
