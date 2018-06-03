using HTTPServer.Server.Contracts;
using System;
using System.IO;
using System.Linq;

namespace HTTPServer.Application.Views
{
    public class SearchView : IView
    {
        private const string ReplacementSnip = "<!--replace-->";

        private string cakeSearchName;

        public SearchView(string cakeName)
        {
            this.cakeSearchName = cakeName;          
        }

        public string View()
        {
            var html = string.Join(Environment.NewLine, File.ReadAllLines(@"../../../Application/Resources/search.html"));

            if (!string.IsNullOrEmpty(this.cakeSearchName) && !string.IsNullOrWhiteSpace(this.cakeSearchName))
            {
                var cakesToReplace = string
                    .Join("",File.ReadLines(@"../../../Application/Resources/search.html")
                    .Where(l => l.Contains(cakeSearchName))
                    .Select(l => $"<div>{l}</div>"));

                html = html.Replace(ReplacementSnip, cakesToReplace);
            }
         
            return html;

        } 
    }
}
