using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxMethod
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thidrNum = int.Parse(Console.ReadLine());

        int maxNum = GetMax(firstNum, secondNum);
        maxNum = GetMax(maxNum, thidrNum);

        Console.WriteLine(maxNum);

    }

    private static int GetMax(int firstNum, int secondNum)
    {
        int maxNum = Math.Max(firstNum, secondNum);
        return maxNum;
    }
}

