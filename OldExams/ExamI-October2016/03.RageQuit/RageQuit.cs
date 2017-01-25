using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class RageQuit
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine().ToUpper().Trim();

        StringBuilder result = new StringBuilder();

        string pattern = @"(\D+)(\d+)";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(inputLine);

        foreach (Match match in matches)
        {
            int count = int.Parse(match.Groups[2].Value);
            string message = match.Groups[1].Value;

            for (int i = 0; i < count; i++)
            {
                result.Append(message);
            }
        }

        int uniqueSymbols = result.ToString().Distinct().Count();
        Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
        Console.WriteLine(result);
    }
}

