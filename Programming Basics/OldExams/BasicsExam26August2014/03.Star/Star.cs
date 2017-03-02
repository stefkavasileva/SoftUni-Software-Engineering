using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Star
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int innerDots = 1;
        int outerDots = n - 1;
        int outerDots2 = 1;

        int middlDots = ((2 * n) + 1) - 4;
        for (int i = 1; i <= n * 2 - (n / 2 - 1); i++)
        {
            if (i >= 1 && i <= (n / 2) + 1)
            {
                if (i == 1)
                {
                    Console.WriteLine("{0}*{0}",
                        new string('.', n));
                }
                else if (i == (n / 2) + 1)
                {
                    int asterisks = outerDots + 1;
                    Console.WriteLine("{0}{1}{0}",
                        new string('*', asterisks),
                        new string('.', innerDots));
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
            else if (i >= (n / 2) + 1 && i <= n)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outerDots2),
                    new string('.', middlDots));
                outerDots2++;
                middlDots -= 2;
            }
            else
            {
                if (i == n * 2 - (n / 2 - 1))
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('*', (n / 2) + 1),
                        new string('.', n - 1));
                }
                else if (i == n + 1)
                {
                    int innerDots2 = outerDots2 - 1;
                    Console.WriteLine("{0}*{1}*{1}*{0}",
                        new string('.', outerDots),
                        new string('.', innerDots2));
                    outerDots--;
                }
                else
                {
                    if (i == n + 2)
                    {
                        middlDots = 1;
                    }
                    int innerDots2 = outerDots2 - 1;
                    Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                        new string('.', outerDots),
                        new string('.', innerDots2),
                        new string('.', middlDots));
                    outerDots--;
                    middlDots += 2;
                }
            }
        }
    }
}

