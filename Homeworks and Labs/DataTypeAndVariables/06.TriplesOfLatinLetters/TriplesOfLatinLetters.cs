using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriplesOfLatinLetters
{
    static void Main(string[] args)
    {
        int stopLetter = int.Parse(Console.ReadLine());

        for (int firstLetter = 0; firstLetter < stopLetter; firstLetter++)
        {
            for (int secondLetter= 0; secondLetter < stopLetter; secondLetter++)
            {
                for (int thirdLetter = 0; thirdLetter < stopLetter; thirdLetter++)
                {
                    Console.WriteLine($"{((char)('a'+firstLetter))}{((char)('a' + secondLetter))}{((char)('a' + thirdLetter))}");
                }
            }
        }
    }
}

