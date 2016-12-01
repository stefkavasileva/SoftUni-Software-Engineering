using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Substring
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endIndex = i + jump;
                string matchedString = string.Empty;

                if (endIndex > text.Length - jump)
                {
                    endIndex = text.Length - 1;
                    matchedString = text.Substring(i);
                }
                else
                {
                    matchedString = text.Substring(i, jump+1);
                }
            
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}

