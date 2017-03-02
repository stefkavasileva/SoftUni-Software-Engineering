using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PandaScotlandFlag1
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int outerSymbol = 0;
        char letter = 'A';
        int diez = n - 2;

        for (int i = 0; i < n / 2; i++)
        {
            if (letter > 'Z')
            {
                letter = 'A';
            }

            Console.WriteLine("{0}{1}{2}{3}{4}",
                new string('~', outerSymbol),
                letter, new string('#', diez),
              letter == 'Z' ? letter = 'A' : ++letter,
              new string('~', outerSymbol));

            outerSymbol++;
            letter++;
            diez -= 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), letter);

        letter++;
        diez = 1;
        outerSymbol = (n / 2) - 1;

        for (int i = 0; i < n / 2; i++)
        {
            if (letter > 'Z')
            {
                letter = 'A';
            }

            Console.WriteLine("{0}{1}{2}{3}{4}",
               new string('~', outerSymbol),
               letter, new string('#', diez),
               letter == 'Z' ? letter = 'A' : ++letter,
               new string('~', outerSymbol));

            outerSymbol--;
            letter++;
            diez += 2;
        }
    }
}

