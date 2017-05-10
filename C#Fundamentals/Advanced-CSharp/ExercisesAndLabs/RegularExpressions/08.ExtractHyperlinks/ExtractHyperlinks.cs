using System;
using System.Text.RegularExpressions;

public class ExtractHyperlinks
{
    public static void Main()
    {
        //80/100
        var input = Console.ReadLine();
        var pattern = @"<a.*?(?<!"">)href\s*?=\s*?([""'])?(\S.*?)(?:>|class|\1)";
        while (input.Substring(input.Length - 3) != "END")
        {
            input += Console.ReadLine();
        }

        input = input.Remove(input.Length - 3);

        var regex = new Regex(pattern);
        var matches = regex.Matches(input);
        var fix = string.Empty;

        foreach (Match match in matches)
        {
            fix = match.Groups[2].ToString();
            fix = Regex.Replace(fix, @"\s{2,}", " ");
            Console.WriteLine(fix);
        }
    }
}

