using System;
using System.Linq;

public class InsertionSortUsingList
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count(); i++)
        {
            var curretnNum = numbers[i];
            var j = 0;
            for (j = i - 1; (j >= 0) && (numbers[j] > curretnNum); j--)
            {
                numbers[j + 1] = numbers[j];
            }

            numbers[j + 1] = curretnNum;
        }
    }
}

