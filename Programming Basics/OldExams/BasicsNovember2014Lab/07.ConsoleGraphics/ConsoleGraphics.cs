using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConsoleGraphics
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintTop(n);
        PrintMiddle(n);
        PrintBottom(n);
    }

    private static void PrintBottom(int n)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('~', 2 * n));
        }
    }

    private static void PrintMiddle(int n)
    {
        int asterisks = ((2 * n) - (n - 1)) / 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('*', asterisks),
                new string(' ', n - 1));
        }
    }

    private static void PrintTop(int n)
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(new string('*', 2 * n));
        }

    }
}

