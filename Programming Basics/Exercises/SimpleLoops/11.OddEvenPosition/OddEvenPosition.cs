using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenPosition
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double evenMin = 1000000000;
        double evenMax = -1000000000;
        double evenSum = 0;
        double oddMin = 10000000000000;
        double oddMax = -100000000000;
        double oddSum = 0;

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += num;
                if (num < evenMin)
                {
                    evenMin = num;
                }

                if (num > evenMax)
                {
                    evenMax = num;
                }
            }
            else
            {
                oddSum += num;
                if (num < oddMin)
                {
                    oddMin = num;
                }

                if (num > oddMax)
                {
                    oddMax = num;
                }
            }
        }

        if (n == 0)
        {
            Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, EvenSum=0, EvenMin=No, EvenMax=No");
        }
        else if (n == 1)
        {
            Console.WriteLine($"OddSum={oddSum}, OddMin={oddSum}, OddMax={oddSum}, EvenSum=0, EvenMin=No, EvenMax=No");
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
        }
    }
}

