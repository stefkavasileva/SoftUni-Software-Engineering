using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DrawAFilledSquare
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        PrintSquare(number);
    }

    private static void PrintSquare(int number)
    {
        PrintEndRow(number);

        for (int i = 0; i < number - 2; i++)
        {
            PrintMiddleRow(number);
        }

        PrintEndRow(number);
    }

    private static void PrintMiddleRow(int number)
    {
        Console.Write('-');

        for (int i = 0; i < number - 1; i++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine('-');
    }

    private static void PrintEndRow(int number)
    {
        Console.WriteLine(new string('-', 2 * number));
    }
}

