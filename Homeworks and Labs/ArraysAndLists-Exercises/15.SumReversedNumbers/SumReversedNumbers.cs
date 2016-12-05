using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumReversedNumbers
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            char [] digit = numbers[i].ToCharArray();
            digit=digit.Reverse().ToArray();

            string numberAsStr = ConcatDigit(digit);
            
            int currentNum = int.Parse(numberAsStr);
            sum += currentNum;
        }

        Console.WriteLine(sum);
    }

    private static string ConcatDigit(char[] digit)
    {
        string number = string.Empty;

        for (int i = 0; i < digit.Length; i++)
        {
            number += (char)digit[i];
        }

        return number;
    }
}

