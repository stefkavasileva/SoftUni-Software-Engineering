using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RockLq
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstSegment = (n + 1) / 2;
        int secondSegment = (n - 1) / 2;
        int thirdSegment = n;
        int outerDots = n - 2;
        int innerDots = n + 2;
        for (int i = 0; i < firstSegment; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n),
                    new string('*', n));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outerDots),
                    new string('.', innerDots));
                innerDots += 4;
                outerDots -= 2; ;
            }
        }

        outerDots = n - 4;
        innerDots = n;
        int middlDots = 1;
        for (int i = 0; i < secondSegment; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('.', n - 2),
                    new string('.', n));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', outerDots),
                    new string('.', middlDots),
                    new string('.', innerDots));
                outerDots -= 2;
                middlDots += 2;
            }

        }

        outerDots = n - 1;
        innerDots = n;
        for (int i = 0; i < thirdSegment; i++)
        {
            if (i == thirdSegment - 1)
            {
                Console.WriteLine("{0}", new string('*', n * 3));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outerDots),
                    new string('.', innerDots));
                outerDots--;
                innerDots += 2;
            }
        }
    }
}

