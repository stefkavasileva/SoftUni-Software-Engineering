using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumsThreeNumbers
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());


        if (firstNum == secondNum + thirdNum)
        {
            int minNum = Math.Min(secondNum, thirdNum);
            int maxNum = Math.Max(secondNum, thirdNum);

            Console.WriteLine("{0} + {1} = {2}", a, b, firstNum);
        }
        else if (secondNum == firstNum + thirdNum)
        {
            int minNum = Math.Min(firstNum, thirdNum);
            int maxNum = Math.Max(firstNum, thirdNum);

            Console.WriteLine("{0} + {1} = {2}", a, b, secondNum);
        }
        else if (thirdNum == secondNum + firstNum)
        {
            int minNum = Math.Min(firstNum, secondNum);
            int maxNum = Math.Max(firstNum, secondNum);

            Console.WriteLine("{0} + {1} = {2}", a, b, thirdNum);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

