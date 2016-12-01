using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> primesNums = FindPrimesInRange(startNum, endNum);

        PrintPrimesNums(primesNums);
    }

    private static void PrintPrimesNums(List<int> primesNums)
    {
        Console.WriteLine(string.Join(", ",primesNums));
    }

    private static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primesNums = new List<int>();

        bool isPrime = true;
        
        for (int i = startNum; i <= endNum; i++)
        {
            if (i < 2)
            {
                continue;
            }

            for (int j = 2; j <=Math.Sqrt(i); j++)
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

