using System;

public class CheckPrime
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }
}
