using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RefactorSpecialNumbers
{
    static void Main(string[] args)
    {
        int endNum = int.Parse(Console.ReadLine());
        int sumNum = 0;
        int currentNum = 0;
        bool isSpecialNum = false;
        for (int index = 1; index <= endNum; index++)
        {
            currentNum = index;
            while (index > 0)
            {
                sumNum += index % 10;
                index = index / 10;
            }

            isSpecialNum = (sumNum == 5) || (sumNum == 7) || (sumNum == 11);

            Console.WriteLine($"{currentNum} -> {isSpecialNum}");
            sumNum = 0;
            index = currentNum;
        }

    }
}

