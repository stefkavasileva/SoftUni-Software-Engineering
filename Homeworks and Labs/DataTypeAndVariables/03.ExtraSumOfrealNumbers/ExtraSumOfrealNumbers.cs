using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtraSumOfrealNumbers
{
    static void Main(string[] args)
    {
        int inputNums = int.Parse(Console.ReadLine());

        decimal sum = 0M;

        for (int i = 0; i < inputNums; i++)
        {
            decimal currentRealNum = decimal.Parse(Console.ReadLine());
            sum += currentRealNum;
        }

        Console.WriteLine(sum);
    }
}

