using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MelrahShake
{
    static void Main(string[] args)
    {
        string randomCharacters = Console.ReadLine();
        string pattern = Console.ReadLine();


        List<string> messages = new List<string>();

        if (pattern.Length == 0)
        {
            Console.WriteLine( "No shake.");
            Console.WriteLine(randomCharacters);
            return;
        }

        while (true)
        {
            int firstOccureence = randomCharacters.IndexOf(pattern);
            int lastOccureence = randomCharacters.LastIndexOf(pattern);

            if (firstOccureence > -1 && lastOccureence > -1 && pattern.Length > 0)
            {
                randomCharacters = randomCharacters.Remove(lastOccureence, pattern.Length);
                randomCharacters = randomCharacters.Remove(firstOccureence, pattern.Length);
                messages.Add("Shaked it.");

                pattern = pattern.Remove(pattern.Length / 2, 1);

            }
            else
            {
                messages.Add("No shake.");
                break;
            }

        }
        foreach (var m in messages)
        {
            Console.WriteLine(m);
        }

        Console.WriteLine(randomCharacters);

    }
}

