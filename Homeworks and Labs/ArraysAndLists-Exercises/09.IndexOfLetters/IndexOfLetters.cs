using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine($"{text[i]} -> {text[i] - 97}");
        }
    }
}

