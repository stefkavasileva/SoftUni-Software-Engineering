using System;
using System.Linq;

public class RecursiveFibonacci
{

    private static long[] fibMumers = new long[100];

    public static void Main()
    {
        fibMumers = fibMumers.Select(x => x = -1).ToArray();

        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetFibonnaciNum(n));
    }

    public static long GetFibonnaciNum(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        if (fibMumers[n] != -1)
        {
            return fibMumers[n];
        }

        fibMumers[n] = GetFibonnaciNum(n - 1) + GetFibonnaciNum(n - 2);
        return fibMumers[n];
    }
}

