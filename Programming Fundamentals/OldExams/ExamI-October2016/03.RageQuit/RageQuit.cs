using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
    public static void Main()
    {
        var text = Console.ReadLine().ToUpper();

        var regex = new Regex(@"(\D+)(\d+)");
        var matches = regex.Matches(text);

        var result = new StringBuilder();
       
        foreach (Match match in matches)
        {
            var symbols = match.Groups[1].Value;
            var counter = int.Parse(match.Groups[2].Value);
            result.Append(string.Concat(Enumerable.Repeat(symbols, counter)));
        }

        Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
        Console.WriteLine(result.ToString());
    }
}
