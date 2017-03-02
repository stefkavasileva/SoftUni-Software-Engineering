using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChristmasTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} | ", new string(' ', n));

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}{1} | {1}{0}",
                new string(' ', n - row),
                new string('*', row));

        }
    }
}

