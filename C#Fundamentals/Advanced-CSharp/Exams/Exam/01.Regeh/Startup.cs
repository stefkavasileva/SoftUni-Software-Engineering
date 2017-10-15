using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Regeh
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var matches = new Regex(@"\[\S+?<(\d+)REGEH(\d+)>\S+?]").Matches(input);
            var matchNumbers = new Regex(@"\d+");
            var allNumbers = new List<int>();

            foreach (Match match in matches)
            {
                var lastIndex = match.Value.LastIndexOf('[');
                var currentMatch = match.Value.Substring(lastIndex);
                var indexOf = currentMatch.IndexOf("<");
                if (!char.IsDigit(currentMatch[indexOf + 1])) continue;
                foreach (Match numberMatch in matchNumbers.Matches(currentMatch))
                {
                    allNumbers.Add(int.Parse(numberMatch.Value));
                }
            }

            var result = new StringBuilder();

            for (int i = 0; i < allNumbers.Count; i++)
            {
                long sumIndex = allNumbers[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    sumIndex += allNumbers[j];
                }

                sumIndex %= input.Length - 1;
                result.Append(input[(int)sumIndex]);
            }

            Console.WriteLine(result);
        }
    }
}
