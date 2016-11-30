using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstWord = "Hello";
        string secondWord = "World";

        object concatinatedStrings = firstWord + " " + secondWord;

        string result = concatinatedStrings.ToString();

        Console.WriteLine(result);
    }
}

