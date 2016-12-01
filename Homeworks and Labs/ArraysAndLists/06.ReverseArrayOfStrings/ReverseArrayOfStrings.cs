using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseArrayOfStrings
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string[] letters = text.Split(' ');
        letters = letters.Reverse().ToArray();

        foreach (string letter in letters)
        {
            Console.Write(letter);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

