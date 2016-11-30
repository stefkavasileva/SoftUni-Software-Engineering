using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintingTriangle
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        PrintRectangle(number);
    }

    private static void PrintRectangle(int number)
    {
        for (int i = 1; i <=number; i++)
        {
            PrintRow(1,i);
        }

        for (int i = number-1; i >=0 ; i--)
        {
            PrintRow(1, i);
        }
    }

    private static void PrintRow(int start, int end)
    {
        for (int i = start; i <=end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

