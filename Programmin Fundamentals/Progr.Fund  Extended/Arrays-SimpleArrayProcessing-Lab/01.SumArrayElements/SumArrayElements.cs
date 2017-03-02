using System;
using System.Collections.Generic;
using System.Linq;

public class SumArrayElements
{
    public static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var numbers = new int[numbersCount];

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(numbers.Sum());
    }
}
