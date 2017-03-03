using System;
using System.Collections.Generic;
using System.Linq;

public class OddEvenSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> oddNums = new List<int>();
        List<int> evenNums = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            evenNums.Add(num2);
            oddNums.Add(num1);
        }

        int oddSum = oddNums.Sum();
        int evenSum = evenNums.Sum();

        if (evenSum == oddSum)
        {
            Console.WriteLine($"Yes, sum={evenSum}");
        }
        else
        {
            Console.WriteLine($"No, diff={Math.Abs(evenSum - oddSum)}");
        }
    }
}