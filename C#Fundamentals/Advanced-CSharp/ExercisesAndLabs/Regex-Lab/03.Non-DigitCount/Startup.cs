using System;
using System.Text.RegularExpressions;

namespace _03.Non_DigitCount
{
    public class Startup
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"\D";
            var reg = new Regex(pattern);
            var matchesCount = reg.Matches(text).Count;

            Console.WriteLine($"Non-digits: {matchesCount}");
        }
    }
}
