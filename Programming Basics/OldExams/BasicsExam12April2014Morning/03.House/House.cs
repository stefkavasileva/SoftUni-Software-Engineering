using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}",
            new string('.', n / 2));

        int outerDots = (n / 2) - 1;
        int innerDots = 1;

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innerDots));

            outerDots--;
            innerDots += 2;
        }

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
                new string('.', n / 4),
                new string('.', n - (2 * (n / 4) + 2)));
        }

        Console.WriteLine("{0}{1}{0}",
            new string('.', n / 4),
            new string('*', n - (2 * (n / 4) + 2) + 2));
    }
}

