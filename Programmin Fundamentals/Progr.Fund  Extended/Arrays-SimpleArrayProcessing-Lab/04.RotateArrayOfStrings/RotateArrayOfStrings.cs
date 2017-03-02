using System;
using System.Linq;

public class RotateArrayOfStrings
{
    public static void Main()
    {
        var words = Console.ReadLine().Split().ToArray();

        var lastWord = words.Last();

        for (int i = words.Length - 1; i > 0; i--)
        {
            words[i] = words[i - 1];
        }

        words[0] = lastWord;

        Console.WriteLine(string.Join(" ", words));
    }
}