using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Axe
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int innerDashes = 0;
        int outerDashes = (2 * n) - 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', 3 * n),
                new string('-', innerDashes),
                new string('-', outerDashes));
            innerDashes++;
            outerDashes--;
        }

        innerDashes--;
        outerDashes++;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('*', 3 * n),
                new string('-', innerDashes),
                new string('-', outerDashes));
        }

        int dashes = 3 * n;

        for (int i = 0; i < n / 2; i++)
        {
            if (i == (n / 2) - 1)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', dashes),
                    new string('*', innerDashes),
                    new string('-', outerDashes));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', dashes),
                    new string('-', innerDashes),
                    new string('-', outerDashes));
                innerDashes += 2;
                outerDashes--;
                dashes--;
            }
        }
    }
}

