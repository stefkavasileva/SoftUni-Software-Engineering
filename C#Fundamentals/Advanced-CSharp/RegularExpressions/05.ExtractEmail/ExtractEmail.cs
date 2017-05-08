using System;
using System.Text.RegularExpressions;

public class ExtractEmail
{
    public static void Main()
    {
        var textItems = Console.ReadLine();

        var pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";
        var reg = new Regex(pattern);
        var matches = reg.Matches(textItems);

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

