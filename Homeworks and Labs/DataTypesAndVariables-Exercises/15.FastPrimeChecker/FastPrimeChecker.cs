using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FastPrimeChecker
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        for (int index = 2; index <= num; index++)
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(index); i++)
            {
                if (index % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{index} -> {isPrime}");
        }

    }
}

