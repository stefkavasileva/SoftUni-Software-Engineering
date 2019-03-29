using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class ReplaceTag
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        var pattern = @"<a.*href=(""|')(.*)\1>(.*?)<\/a>";

        while (!inputLine.Equals("end"))
        {

            var reg = new Regex(pattern);
            var matches = reg.Matches(inputLine);

            inputLine = reg.Replace(inputLine, @"[URL href=""$2""]$3[/URL]");

            Console.WriteLine(inputLine);

            inputLine = Console.ReadLine();
        }
    }
}
