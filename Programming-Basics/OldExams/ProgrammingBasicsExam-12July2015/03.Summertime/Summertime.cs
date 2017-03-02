using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Summertime
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int space = (n - 1) / 2;
        int innerElement = n + 1;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string(' ', space),
                    new string('*', innerElement));
            }
            else if (i > 1 && i <= (n / 2) + 2)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string(' ', space),
                    new string(' ', n - 1));
            }
            else
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string(' ', space - 1),
                    new string(' ', innerElement));
                space--;
                innerElement += 2;

            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', (2 * n) - 2));
        }

        for (int i = 0; i <= n; i++)
        {
            if (i == n)
            {
                Console.WriteLine("*{0}*", new string('*', (2 * n) - 2));
            }
            else
            {
                Console.WriteLine("*{0}*", new string('@', (2 * n) - 2));
            }

        }
    }
}


