using System;
using System.Linq;

public class FlipListSides
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 1; i < numbers.Count / 2; i++)
        {
            var firstNum = numbers[i];
            var lastNum = numbers[numbers.Count - i - 1];

            numbers[i] = lastNum;
            numbers[numbers.Count - i - 1] = firstNum;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
