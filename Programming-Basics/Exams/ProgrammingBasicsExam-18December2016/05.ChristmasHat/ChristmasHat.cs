using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChristmasHat
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}/|\\{0}", new string('.', 2 * size - 1));
        Console.WriteLine("{0}\\|/{0}", new string('.', 2 * size - 1));
        Console.WriteLine("{0}***{0}", new string('.', 2 * size - 1));

        int outerDots = size * 2 - 2;
        int dashes = 1;

        for (int i = 0; i < size*2-1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string ('.',outerDots),
                new string('-',dashes));

            dashes++;
            outerDots--;
        }

        Console.WriteLine(new string('*', size * 4 + 1));

        for (int i = 0; i < 4*size+1; i++)
        {
            Console.Write(i % 2 == 0 ? '*' : '.');
        }

        Console.WriteLine();

        Console.WriteLine(new string('*', size * 4 + 1));
    }
}

