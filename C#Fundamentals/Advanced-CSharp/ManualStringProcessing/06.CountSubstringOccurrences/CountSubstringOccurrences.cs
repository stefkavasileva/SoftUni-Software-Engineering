using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        var text = Console.ReadLine().ToLower();
        var pattern = Console.ReadLine().ToLower();

        var index = 0;
        var count = 0;

        while (index > -1)
        {
            index = text.IndexOf(pattern, index + 1);

            if (index > -1)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

