using System;
using System.Linq;

public class FoldAndSum 
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] firstElements = numbers.Take(numbers.Length / 4).ToArray();
        Array.Reverse(firstElements);

        int[] lastElements = numbers
            .Skip(numbers.Length - (numbers.Length / 4))
            .Take(numbers.Length / 4)
            .ToArray();
        Array.Reverse(lastElements);

        int[] concatedElements = firstElements.Concat(lastElements).ToArray();

        int[] middleElements = numbers
                   .Skip(numbers.Length / 4)
                   .Take(numbers.Length / 2)
                   .ToArray();

        int[] sum = new int[middleElements.Length];

        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = middleElements[i] + concatedElements[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}