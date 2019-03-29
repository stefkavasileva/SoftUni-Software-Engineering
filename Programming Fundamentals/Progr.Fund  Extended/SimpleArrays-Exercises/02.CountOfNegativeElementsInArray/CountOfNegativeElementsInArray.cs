using System;
using System.Linq;

public class CountOfNegativeElementsInArray
{
    public static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());

        var numbers = new int[numbersCount];
        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var negativeNumbersCount = numbers.Where(x => x < 0).Count();
        Console.WriteLine(negativeNumbersCount);
    }
}
