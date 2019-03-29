using System;
using System.Linq;


public class ShortWordsSorted
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(".,:;()[]\"\'\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(w => w.Trim())
            .Where(w => w.Length < 5)
            .OrderBy(w=>w)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ",words));
    }
}

