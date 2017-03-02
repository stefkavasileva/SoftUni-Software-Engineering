using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxNumber
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        int maxNum = int.MinValue;

        for (int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > maxNum)
            {
                maxNum = num;
            }
        }

        Console.WriteLine(maxNum);
    }
}

