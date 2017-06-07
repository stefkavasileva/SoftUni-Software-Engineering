using System;
using System.Linq;
using System.Text;

namespace _02.ParseURLs
{
    public class Startup
    {
        public static void Main()
        {
            var url = Console.ReadLine();
            var urlArgs = url.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var sb = new StringBuilder();
            if (urlArgs.Length == 2)
            {
                var protocol = urlArgs[0];
                var server = string.Empty;

                var indexOfProtocolEnd = urlArgs[1].IndexOf('/');
                if (indexOfProtocolEnd < 0)
                {
                    Console.WriteLine("Invalid URL");
                    return;
                }

                server = urlArgs[1].Substring(0, indexOfProtocolEnd);
                var resource = string.Empty;
                if (indexOfProtocolEnd != urlArgs[1].Length - 1)
                {
                     resource = urlArgs[1].Substring(indexOfProtocolEnd + 1);
                }
             
                sb.AppendLine($"Protocol = {protocol}");
                sb.AppendLine($"Server = {server}");
                sb.AppendLine($"Resources = {resource}");
            }
            else
            {
                sb.AppendLine("Invalid URL");
            }

            Console.Write(sb);
        }
    }
}
