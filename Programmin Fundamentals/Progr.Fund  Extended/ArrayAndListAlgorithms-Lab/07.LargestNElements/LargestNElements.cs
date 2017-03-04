using System;
using System.Linq;

public class LargestNElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            var curretnNum = numbers[i];
            var j = 0;
            for (j = i - 1; (j >= 0) && (numbers[j] > curretnNum); j--)
            {
                numbers[j + 1] = numbers[j];
            }

            numbers[j + 1] = curretnNum;
        }

        Array.Reverse(numbers);

        var largestNElements = numbers.Take(count);
        Console.WriteLine(string.Join(" ", largestNElements));
    }
}