using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxMethod
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int biggerNum = GetMax(firstNumber, secondNumber);
        int biggestNum = GetMax(thirdNumber, biggerNum);

        Console.WriteLine(biggestNum);

    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        return Math.Max(firstNumber, secondNumber);
    }
}

