using System;
using System.Linq;

public class SmallestElementInArray
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Count(); i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        Console.WriteLine(minNumber);
    }
}
