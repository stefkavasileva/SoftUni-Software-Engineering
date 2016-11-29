using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpecialNumbers
{
    static void Main(string[] args)
    {
        int endNums = int.Parse(Console.ReadLine());

        for (int i = 1; i <= endNums; i++)
        {
            int currentNum = i;

            int firstDigit = (currentNum / 10) % 10;
            int lastDigit = currentNum % 10;
            int sumOfDigit = firstDigit + lastDigit;

            if (sumOfDigit == 5 || sumOfDigit == 11 || sumOfDigit == 7)
            {
                Console.WriteLine($"{i} -> True");
            }
            else
            {
                Console.WriteLine($"{i} -> False");
            }
        }
    }
}

