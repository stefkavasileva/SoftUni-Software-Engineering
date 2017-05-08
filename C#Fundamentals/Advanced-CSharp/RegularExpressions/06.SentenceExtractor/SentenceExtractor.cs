using System;
using System.Text.RegularExpressions;

public class SentenceExtractor
{
    public static void Main()
    {
        var reg = new Regex(@".+?[!\./?]");
        var word = Console.ReadLine();
        var text = Console.ReadLine();

        foreach (Match match in reg.Matches(text))
        {
            if (match.Value.Contains(" " + word + " "))
            {
                Console.WriteLine(match.Value.Trim());
            }
        }
    }
}

