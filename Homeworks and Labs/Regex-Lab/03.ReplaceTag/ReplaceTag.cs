using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        //66/100
        var result = new List<string>();

        var pattern = @"<a.*href=(""|')(.*)\1>(.*?)<\/a>";
        var inputLine = Console.ReadLine();

        var reg = new Regex(pattern);
        var matches = reg.Matches(inputLine);

        inputLine = reg.Replace(inputLine, @"[URL href=""$2""]$3[/URL]");

        Console.WriteLine(inputLine);
    }
}

