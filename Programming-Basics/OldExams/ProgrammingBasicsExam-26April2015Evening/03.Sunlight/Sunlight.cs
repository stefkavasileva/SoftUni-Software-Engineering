using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sunlight
{
    static void Main(string[] args)
    {

        int size = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('.', ((3 * size) - 1) / 2));
        int innerDots = ((3 * size) - 5) / 2;
        int outerDots = 1;
        for (int i = 1; i <= size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innerDots));
            innerDots--;
            outerDots++;
        }

        for (int i = 1; i <= size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', outerDots),
                new string('*', size));
        }
        Console.WriteLine("{0}", new string('*', size * 3));
        for (int i = 1; i <= size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
               new string('.', outerDots),
               new string('*', size));
        }
        outerDots--;
        innerDots++;
        for (int i = 1; i <= size - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', outerDots),
                new string('.', innerDots));
            innerDots++;
            outerDots--;
        }

        Console.WriteLine("{0}*{0}", new string('.', ((3 * size) - 1) / 2));
    }
}

