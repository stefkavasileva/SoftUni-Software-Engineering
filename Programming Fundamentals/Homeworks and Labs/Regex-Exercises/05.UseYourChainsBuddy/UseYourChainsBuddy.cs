using System;
using System.Text;
using System.Text.RegularExpressions;

public class UseYourChainsBuddy
{
    public static void Main()
    {
        var htmlText = Console.ReadLine();
        var pattern = @"<p>(.+?)<\/p>";

        var currentMach = string.Empty;

        foreach (Match match in Regex.Matches(htmlText, pattern))
        {
            currentMach += match.Groups[1].Value.ToString();
        }

        currentMach = Regex.Replace(currentMach, @"[^a-z\d]", " ");
        currentMach = Regex.Replace(currentMach, @"\s+|\n+", " ");
        var result = new StringBuilder(currentMach.Length);

        foreach (var ch in currentMach)
        {
            if (ch >= 'a' && ch <= 'm')
            {
                result.Append((char)(ch + 13));
            }
            else if (ch >= 'n' && ch <= 'z')
            {
                result.Append((char)(ch - 13));
            }
            else
            {
                result.Append(ch);
            }
        }

        Console.WriteLine(result);
    }
}
