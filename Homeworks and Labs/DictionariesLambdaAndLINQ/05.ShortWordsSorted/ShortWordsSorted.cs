using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShortWordsSorted
{
    static void Main(string[] args)
    {
        char[] separators = ".,:;()[]\"\'\\/!? ".ToCharArray();
        string[] words = Console.ReadLine()
            .ToLower()
            .Split(separators, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        words = words.Where(x => x.Length < 5).OrderBy(a => a).ToArray();
        words = words.Distinct().ToArray();

        Console.WriteLine(string.Join(", ",words));




    }
}

