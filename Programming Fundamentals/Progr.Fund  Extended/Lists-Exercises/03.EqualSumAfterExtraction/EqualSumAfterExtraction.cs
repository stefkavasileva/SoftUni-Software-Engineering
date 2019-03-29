using System;
using System.Linq;

public class EqualSumAfterExtraction
{
    public static void Main()
    {
        var firstArr = Console.ReadLine().Split().Select(int.Parse).ToList();
        var secondArr = Console.ReadLine().Split().Select(int.Parse).ToList();

        var sumOfEqualsElements = secondArr.Sum() - secondArr.Where(x => firstArr.Contains(x)).Sum();
        var firstArrSum = firstArr.Sum();

        var result = sumOfEqualsElements == firstArrSum ? 
            $"Yes. Sum: {firstArrSum}" : 
            $"No. Diff: {Math.Abs(firstArrSum - sumOfEqualsElements)}";

        Console.WriteLine(result);
    }
}
