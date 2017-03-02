using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinNumber
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        int minNum = int.MaxValue;

        for (int i = 0; i < numbers; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < minNum)
            {
                minNum = num;
            }
        }

        Console.WriteLine(minNum);
    }
}

