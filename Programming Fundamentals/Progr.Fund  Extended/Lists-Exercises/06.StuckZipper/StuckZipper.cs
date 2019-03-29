using System;
using System.Collections.Generic;
using System.Linq;

public class StuckZipper
{
    public static void Main()
    {
        var firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        var minLen = Math.Min(GetMinLen(firstNumbers), GetMinLen(secondNumbers));//get element with the smallest amount of digits in both of the lists

       // Get the elements with less ot same digits than the element with the smallest amount of digits
        var firstMinNumbers = GetMinNumbers(minLen, firstNumbers); 
        var secondMinNumbers = GetMinNumbers(minLen, secondNumbers);

        var maxLen = Math.Max(firstMinNumbers.Count, secondMinNumbers.Count()); 
        var result = new List<int>();

        for (int i = 0; i < maxLen; i++)
        {
            AddNumbers(i, secondMinNumbers, result);
            AddNumbers(i, firstMinNumbers, result);
        }

        Console.WriteLine(string.Join(" ", result));
    }

    public static void AddNumbers(int i, List<int> numbers, List<int> result)
    {
        if (i < numbers.Count())
        {
            result.Add(numbers[i]);
        }
    }

    public static List<int> GetMinNumbers(int minLen, List<int> numbers)
    {
        var minNumbers = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            var len = numbers[i] < 0 ? numbers[i].ToString().Length - 1 : numbers[i].ToString().Length;
            if (len <= minLen)
            {
                minNumbers.Add(numbers[i]);
            }
        }

        return minNumbers;
    }

    public static int GetMinLen(List<int> numbers)
    {
        var minLen = int.MaxValue;
        for (int i = 0; i < numbers.Count; i++)
        {
            var currentNum = numbers[i].ToString();
            var len = numbers[i] < 0 ? currentNum.Length - 1 : currentNum.Length;
            if (len <= minLen)
            {
                minLen = len;
            }
        }

        return minLen;
    }
}