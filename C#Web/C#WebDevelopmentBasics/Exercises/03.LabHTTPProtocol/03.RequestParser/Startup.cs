using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.RequestParser
{
    public class Startup
    {
        public static void Main()
        {
            var methodPaths = new Dictionary<string, HashSet<string>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                var inputArgs = inputLine.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                var path = inputArgs.First();
                var method = inputArgs.Last();

                if (!methodPaths.ContainsKey(method))
                {
                    methodPaths.Add(method, new HashSet<string>());
                }

                methodPaths[method].Add(path);

                inputLine = Console.ReadLine();
            }

            var requestLine = Console.ReadLine();
            var requestArgs = requestLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var methodName = requestArgs[0].ToLower();
            var pathName = requestArgs[1].ToLower().Substring(1);
            var version = requestArgs[2];

            var statusCode = string.Empty;
            var content = string.Empty;
            if (!methodPaths.ContainsKey(methodName) || !methodPaths[methodName].Any(p => p == pathName))
            {
                statusCode = "404 NotFound";
                content = "Not Found";
            }
            else
            {
                statusCode = "200 OK";
                content = "OK";
            }

            var sb = new StringBuilder();
            sb.AppendLine($"{version} {statusCode}");
            sb.AppendLine($"Content-Length: {content.Length}");
            sb.AppendLine($"Content-Type: text/plain{Environment.NewLine}");
            sb.AppendLine(content);

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
