using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumbersInReversedOrder
{
    static void Main(string[] args)
    {
        char[] decimalNum = Console.ReadLine().ToCharArray();

        string reversedNum = ReverseNumber(decimalNum);
        Console.WriteLine(reversedNum);
    }

    private static string ReverseNumber(char[] decimalNum)
    {
        Array.Reverse(decimalNum);
        return string.Join("", decimalNum);
    }
}

