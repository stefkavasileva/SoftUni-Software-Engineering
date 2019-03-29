using System;
using System.Linq;

public class RotateAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rotatedCount = int.Parse(Console.ReadLine());

        int[] sum = new int[numbers.Length];

        for (int i = 0; i < rotatedCount; i++)
        {
            RotatingArray(numbers);
            SumTwoArrays(numbers, sum);
        }

        Console.WriteLine(string.Join(" ", sum));
    }

    private static void SumTwoArrays(int[] numbers, int[] sum)
    {
        for (int i = 0; i < sum.Length; i++)
        {
            sum[i] = numbers[i] + sum[i];
        }
    }

    private static void RotatingArray(int[] numbers)
    {
        int lastNum = numbers[numbers.Length - 1];

        for (int i = numbers.Length - 1; i > 0; i--)
        {
            numbers[i] = numbers[i - 1];
        }

        numbers[0] = lastNum;
    }
}