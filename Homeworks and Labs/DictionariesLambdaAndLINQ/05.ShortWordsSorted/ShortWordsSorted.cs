using System;
using System.Linq;

public class ShortWordsSorted
{
    public static void Main()
    {
        char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();

        string[] words = Console.ReadLine()
            .ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        words = words.Where(x => x.Length < 5).OrderBy(a => a).ToArray();
        words = words.Distinct().ToArray();

        Console.WriteLine(string.Join(", ", words));
    }
}
