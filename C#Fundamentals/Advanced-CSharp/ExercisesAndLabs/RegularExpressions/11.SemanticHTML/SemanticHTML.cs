using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SemanticHTML
{
    static void Main(string[] args)
    {
        //85/100
        var input = Console.ReadLine();
        var openTagPattern = @"<div(\s*.+)?\s+\w+\s?=\s?""(\w+)""\s*(\s.+)?>";
        var closeTagPattern = @"<\/div>\s*<!--\s*(\w+)\s*-->";
        var output = new List<string>();

        while (input != "END")
        {
            if (Regex.IsMatch(input, openTagPattern))
            {
                var matches = Regex.Match(input, openTagPattern);
                var tagName = matches.Groups[2].Value;
                var beforeTagname = matches.Groups[1].Value;
                var afterTagname = matches.Groups[3].Value;
                var result = "<" + tagName + beforeTagname + afterTagname + ">";
                output.Add(result);

            }
            else if (Regex.IsMatch(input, closeTagPattern))
            {
                var matches = Regex.Match(input, closeTagPattern);
                var tagName = matches.Groups[1].Value;
                var result = "</" + tagName + ">";
                output.Add(result);
            }
            else
            {
                output.Add(input);
            }

            input = Console.ReadLine();

        }

        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }
}

