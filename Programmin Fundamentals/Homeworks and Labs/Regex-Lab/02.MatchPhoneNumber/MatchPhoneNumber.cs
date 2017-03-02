using System;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        var pattern = @"\+\d{3}(\s|-)\d{1}\1\d{3}\1\d{4}(?!\d)";
        var input = Console.ReadLine();
        var reg = new Regex(pattern);

        var matches = reg.Matches(input);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

