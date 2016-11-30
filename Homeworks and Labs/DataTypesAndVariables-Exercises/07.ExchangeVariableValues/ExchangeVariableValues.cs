using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int firstNum = 5;
        int secondNum = 10;

        Console.WriteLine("Before: ");
        Console.WriteLine($"a = {firstNum}");
        Console.WriteLine($"b = {secondNum}");

        int tempNum = secondNum;

        secondNum = firstNum;
        firstNum = tempNum;

        Console.WriteLine("After: ");
        Console.WriteLine($"a = {firstNum}");
        Console.WriteLine($"b = {secondNum}");
    }
}

