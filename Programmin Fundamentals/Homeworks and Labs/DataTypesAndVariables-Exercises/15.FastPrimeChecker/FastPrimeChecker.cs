using System;

public class FastPrimeChecker
{
    public static void Main()
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
