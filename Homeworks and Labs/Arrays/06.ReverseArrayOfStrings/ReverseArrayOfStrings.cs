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
        string[] letters = text.Split(' ').ToArray();

        Array.Reverse(letters);

        Console.WriteLine(string.Join(" ",letters));
       
    }
}

