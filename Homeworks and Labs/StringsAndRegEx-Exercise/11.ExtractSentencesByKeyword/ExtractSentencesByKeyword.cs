using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractSentencesByKeyword
{
    static void Main(string[] args)
    {
        string inputPattern = Console.ReadLine().Trim();
        string[] text = Console.ReadLine()
            .Split(new char[] { '.', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string pattern="\\b"+inputPattern+"\\b";
       
        Regex reg = new Regex(pattern);

        for (int i = 0; i < text.Length; i++)
        {
            if (reg.IsMatch(text[i]))
            {
                Console.WriteLine(text[i].Trim());
            }
        }
    }
}

