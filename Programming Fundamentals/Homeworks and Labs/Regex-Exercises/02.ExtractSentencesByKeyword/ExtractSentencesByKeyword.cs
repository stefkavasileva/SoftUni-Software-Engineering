using System;
using System.Text.RegularExpressions;

public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var inputPattern = Console.ReadLine().Trim();
        var text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        var pattern = "\\b" + inputPattern + "\\b";

        var reg = new Regex(pattern);

        for (int i = 0; i < text.Length; i++)
        {
            if (reg.IsMatch(text[i]))
            {
                Console.WriteLine(text[i].Trim());
            }
        }
    }
}