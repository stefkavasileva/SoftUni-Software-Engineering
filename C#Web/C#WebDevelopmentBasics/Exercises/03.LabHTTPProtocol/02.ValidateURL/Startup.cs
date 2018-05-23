using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.ValidateURL
{
    public class Startup
    {
        public static void Main()
        {
            var encodedUrl = Console.ReadLine();
            var decodeUrl = WebUtility.UrlDecode(encodedUrl);

            var urlReg = new Regex(@"(http[s]*:\/\/)*([w+\.+\w+]+):*(\d+)*([\/\w*\/*]*)\?*(\w+=\w+&*)*#*(\w+)*");
            var urlMatch = urlReg.Match(decodeUrl);
            if (!urlMatch.Success)
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = urlMatch.Groups[1].Value.Trim(new char[] { '/', ':' });
            var host = urlMatch.Groups[2].Value;
            var port = urlMatch.Groups[3].Value;
            if ((protocol == "http" && port == "443") || (protocol == "https" && port == "80"))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var path = urlMatch.Groups[4].Value;
            var queryStrings = string.Join("", urlMatch.Groups[5].Captures);
            var fragment = urlMatch.Groups[6].Value;

            var sb = new StringBuilder();
            sb.AppendLine($"Protocol: {protocol}");
            sb.AppendLine($"Host: {host}");
            if (port == "" && protocol == "http")
            {
                port = "80";
            }
            else if (port == "" && protocol == "https")
            {
                port = "443";
            }

            sb.AppendLine($"Port: {port}");         
            sb.AppendLine($"Path: {path}");
            if (queryStrings != "") sb.AppendLine($"Query: {queryStrings}");
            if (fragment != "") sb.AppendLine($"Fragment: {fragment}");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
