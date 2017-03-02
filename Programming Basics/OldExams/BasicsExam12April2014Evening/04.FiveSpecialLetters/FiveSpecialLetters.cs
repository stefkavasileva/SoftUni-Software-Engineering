using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FiveSpecialLetters
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        List<string> specialLetters = new List<string>();

        Dictionary<char, int> lettersWeight = new Dictionary<char, int>();
        lettersWeight.Add('a', 5);
        lettersWeight.Add('b', -12);
        lettersWeight.Add('c', 47);
        lettersWeight.Add('d', 7);
        lettersWeight.Add('e', -32);

        for (char letter1 = 'a'; letter1 <= 'e'; letter1++)
        {
            for (char letter2 = 'a'; letter2 <= 'e'; letter2++)
            {
                for (char letter3 = 'a'; letter3 <= 'e'; letter3++)
                {
                    for (char letter4 = 'a'; letter4 <= 'e'; letter4++)
                    {
                        for (char letter5 = 'a'; letter5 <= 'e'; letter5++)
                        {
                            List<char> letters = new List<char>() { letter1, letter2, letter3, letter4, letter5, };
                            letters = letters.Distinct().ToList();

                            int weight = 0;

                            for (int i = 0; i < letters.Count; i++)
                            {
                                weight += (i + 1) * lettersWeight[letters[i]];
                            }

                            if (weight >= start && weight <= end)
                            {
                                specialLetters.Add(letter1.ToString() + letter2 + letter3 + letter4 + letter5);
                            }
                        }
                    }
                }
            }
        }

        if (specialLetters.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", specialLetters));
        }
    }
}

