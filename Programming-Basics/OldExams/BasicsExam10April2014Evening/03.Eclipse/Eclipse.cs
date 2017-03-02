using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Eclipse
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(" {0} {1} {0} ",
            new string('*', (2 * n) - 2),
            new string(' ', n - 1));

        for (int i = 1; i <= n - 2; i++)
        {
            if (i == n / 2)
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', (2 * n) - 2),
                    new string('-', n - 1));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', (2 * n) - 2),
                    new string(' ', n - 1));
            }
        }

        Console.WriteLine(" {0} {1} {0} ",
            new string('*', (2 * n) - 2),
            new string(' ', n - 1));
    }
}

