using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DrawFort
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int middleTop = (2 * n) - ((n / 2) * 2) - 4;
        int size = n - 2;
        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', n / 2),
            new string('_', middleTop));

        for (int i = 0; i < size; i++)
        {
            if (i == size - 1)
            {
                Console.WriteLine("|{0}{1}{0}|",
            new string(' ', (n / 2) + 1),
            new string('_', middleTop));
                continue;
            }

            Console.WriteLine("|{0}|",
                new string(' ', (2 * n) - 2));
        }

        Console.WriteLine("\\{0}/{1}\\{0}/",
           new string('_', n / 2),
           new string(' ', middleTop));

    }
}

