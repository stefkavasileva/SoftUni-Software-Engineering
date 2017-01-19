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
        int sum = 0;
        int currentNum = 0;
        bool isSpecialNum = false;
        for (int index = 1; index <= endNum; index++)
        {
            currentNum = index;
            while (index > 0)
            {
                sum += index % 10;
                index = index / 10;
            }

            isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);

            Console.WriteLine($"{currentNum} -> {isSpecialNum}");
            sum = 0;
            index = currentNum;
        }

    }
}

