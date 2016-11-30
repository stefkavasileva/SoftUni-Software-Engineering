using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReversedChars
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());

        Console.WriteLine(thirdLetter.ToString()+secondLetter+firstLetter);

    }
}

