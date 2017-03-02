using System;
using System.Numerics;

public class FactorialTrailingZeroes
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = GetFactorial(num);

        int trailingZeroes = GetTrailingZeroes(factorial);

        Console.WriteLine(trailingZeroes);
    }

    private static int GetTrailingZeroes(BigInteger factorial)
    {
        int zeroes = 0;
        while (factorial % 10 == 0)
        {
            zeroes++;
            factorial /= 10;
        }

        return zeroes;
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
