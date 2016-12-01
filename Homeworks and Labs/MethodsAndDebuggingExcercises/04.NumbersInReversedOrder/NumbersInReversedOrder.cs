using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersInReversedOrder
{
    static void Main(string[] args)
    {
        char[] decimalNumber = Console.ReadLine().ToCharArray();

        ReverseNum(decimalNumber);

        Console.WriteLine(string.Join("",decimalNumber));
    }

    private static void ReverseNum(char[] decimalNumber)
    {
        Array.Reverse(decimalNumber);
    }
}

