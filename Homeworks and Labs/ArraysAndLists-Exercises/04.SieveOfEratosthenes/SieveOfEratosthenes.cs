using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SieveOfEratosthenes
{
    static void Main(string[] args)
    {     
        int endNum = int.Parse(Console.ReadLine());

        List<int> primesNums = FindPrimesInRange(endNum);


        PrintPrimesNums(primesNums);

    }
    private static void PrintPrimesNums(List<int> primesNums)
    {
        Console.WriteLine(string.Join(" ", primesNums));
    }

    private static List<int> FindPrimesInRange(int endNum)
    {
        List<int> primesNums = new List<int>();

        bool isPrime = true;

        for (int i = 0; i <= endNum; i++)
        {
            if (i < 2)
            {
                continue;
            }

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                primesNums.Add(i);
            }
            else
            {
                isPrime = true;
            }
        }

        return primesNums;
    }
}

