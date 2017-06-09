using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    public class Startup
    {
        public static void Main()
        {
            var pattern = @"^[A-Za-z\d_-]{3,16}$";
            var reg = new Regex(pattern);

            var sb = new StringBuilder();
            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("END"))
            {
                var match = reg.Match(inputLine);
                if (match.Success)
                {
                    sb.AppendLine("valid");
                }
                else
                {
                    sb.AppendLine("invalid");
                }

                inputLine = Console.ReadLine();
            }

            Console.Write(sb);
        }
    }
}
