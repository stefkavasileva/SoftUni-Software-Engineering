using System;
using System.Linq;

public class SumArrays
{
    public static void Main()
    {
        int[] firstNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int firstLength = firstNums.Length;
        int secondLength = secondNums.Length;
        int maxLent = Math.Max(firstNums.Length, secondNums.Length);

        int[] sumOfNums = new int[maxLent];

        for (int i = 0; i < maxLent; i++)
        {
            sumOfNums[i] = firstNums[i % firstLength] + secondNums[i % secondLength];
        }

        Console.WriteLine(string.Join(" ", sumOfNums));
    }
}
