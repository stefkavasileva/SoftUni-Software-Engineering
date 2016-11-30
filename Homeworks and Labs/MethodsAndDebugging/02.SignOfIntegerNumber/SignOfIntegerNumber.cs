using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SignOfIntegerNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        PrintSign(number);
    }

    private static void PrintSign(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}

