using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddAndEvenJumps
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string letters = text.Replace(" ", string.Empty);

        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        List<char> oddLetters = new List<char>();
        List<char> evenLetters = new List<char>();

        for (int i = 0; i < letters.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddLetters.Add(letters[i]);
            }
            else
            {
                evenLetters.Add(letters[i]);
            }
        }

        long oddSum = 0;
        long evenSum = 0;
        int counter = 0;

        for (int i = 0; i < oddLetters.Count; i++)
        {
            counter++;
            if (counter == oddJump)
            {
                oddSum *= oddLetters[i];
                counter = 0;
            }
            else
            {
                oddSum += oddLetters[i];
            }
        }

        counter = 0;

        for (int i = 0; i < evenLetters.Count; i++)
        {
            counter++;
            if (counter == evenJump)
            {
                evenSum *= evenLetters[i];
                counter = 0;
            }
            else
            {
                evenSum += evenLetters[i];
            }
        }

        string oddResult = oddSum.ToString("X");
        string evenResult = evenSum.ToString("X");

        Console.WriteLine("Odd: " + oddResult);
        Console.WriteLine("Even: " + evenResult);
    }
}

