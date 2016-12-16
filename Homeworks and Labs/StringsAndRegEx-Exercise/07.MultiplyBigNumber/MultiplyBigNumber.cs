using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiplyBigNumber
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
        byte secondNumber = byte.Parse(Console.ReadLine());

        if (firstNumber == "0" || secondNumber == 0 || firstNumber == "")
        {
            Console.WriteLine(0);
            return;
        }

        byte product = 0;
        byte numberInMind = 0;
        byte remainder = 0;
        StringBuilder result = new StringBuilder();

        for (int i = firstNumber.Length - 1; i >= 0; i--)
        {
            product = (byte)(byte.Parse(firstNumber[i].ToString()) * secondNumber + numberInMind);
            numberInMind = (byte)(product / 10);
            remainder = (byte)(product % 10);
            result.Append(remainder);
            if (i == 0 && numberInMind != 0)
            {
                result.Append(numberInMind);
            }

        }

        char[] resultToCharArr = result.ToString().ToCharArray();
        Array.Reverse(resultToCharArr);
        Console.WriteLine(new string(resultToCharArr));
    }
}
