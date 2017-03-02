using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LettersCombinations
{
    static void Main(string[] args)
    {
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());
        char invalidLetter = char.Parse(Console.ReadLine());

        int combinations = 0;

        for (char ch1 = startLetter; ch1 <= endLetter; ch1++)
        {
            for (char ch2 = startLetter; ch2 <= endLetter; ch2++)
            {
                for (char ch3 = startLetter; ch3 <= endLetter; ch3++)
                {
                    string currentCombination = ch1.ToString() + ch2 + ch3;

                    if (currentCombination.Contains(invalidLetter))
                    {
                        continue;
                    }

                    Console.Write(currentCombination + " ");
                    combinations++;
                }
            }
        }

        Console.WriteLine(combinations);

    }
}

