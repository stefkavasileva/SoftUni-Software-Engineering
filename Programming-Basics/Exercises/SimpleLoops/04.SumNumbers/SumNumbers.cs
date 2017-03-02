using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumNumbers
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int sumOfNums = 0;

        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sumOfNums += num;
        }

        Console.WriteLine(sumOfNums);
    }
}

