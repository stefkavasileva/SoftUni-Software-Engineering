using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.ExtractTags
{
    public class Startup
    {
        public static void Main()
        {
            var pattern = @"<\/*.+?>";
            var reg = new Regex(pattern);

            var sb = new StringBuilder();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("END"))
            {
                var matches = reg.Matches(inputLine);
                foreach (Match match in matches)
                {
                    sb.AppendLine(match.Groups[0].Value);
                }

                inputLine = Console.ReadLine();
            }

            Console.Write(sb);
        }
    }
}
