using System;
using System.Numerics;

public class BigFactorial
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine(factorial);
    }
}
