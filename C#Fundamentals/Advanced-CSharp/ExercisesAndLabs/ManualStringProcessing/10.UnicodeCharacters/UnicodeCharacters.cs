using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        var text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)text[i]);
        }

        Console.WriteLine();

    }
}

