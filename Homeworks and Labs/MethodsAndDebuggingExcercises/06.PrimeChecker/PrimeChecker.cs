using System;

public class PrimeChecker
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        Console.WriteLine(isPrime);
    }

    private static bool IsPrime(long number)
    {
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
            return isPrime;
        }

        for (long i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }
}
