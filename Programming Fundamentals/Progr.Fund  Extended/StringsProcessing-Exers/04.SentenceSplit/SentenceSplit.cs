using System;
using System.Linq;

public class SentenceSplit
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var delimeter = Console.ReadLine();

        var sentences = text
            .Split(new string[] { delimeter },StringSplitOptions.None)
            .ToArray();

        Console.WriteLine($"[{string.Join(", ",sentences)}]");
    }
}

