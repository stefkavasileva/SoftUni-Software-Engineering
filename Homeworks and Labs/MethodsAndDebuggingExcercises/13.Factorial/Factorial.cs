using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Factorial
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = GetFactorial(num);
        Console.WriteLine(factorial);
    }

    private static BigInteger GetFactorial(int num)
    {
        BigInteger factorial =1;
        for (int i = 2; i <=num; i++)
        {
            factorial*=i;
        }

        return factorial;
    }
}

