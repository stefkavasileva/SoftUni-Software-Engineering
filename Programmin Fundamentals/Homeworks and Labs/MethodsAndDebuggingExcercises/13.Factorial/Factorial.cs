using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = GetFactorial(num);
        Console.WriteLine(factorial);
    }

    private static BigInteger GetFactorial(int num)
    {
        BigInteger factorial = 1;
        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
