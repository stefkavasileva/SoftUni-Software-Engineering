using System;
using System.Linq;

public class SortArrayUsingBubbleSort
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int firstNum = 0; firstNum < numbers.Length; firstNum++)
        {
            for (int seconNum = firstNum + 1; seconNum < numbers.Length; seconNum++)
            {
                if (numbers[seconNum] < numbers[firstNum])
                {
                    var tempNum = numbers[firstNum];
                    numbers[firstNum] = numbers[seconNum];
                    numbers[seconNum] = tempNum;
                }
            }
        }

        Console.WriteLine(string.Join(" ",numbers));
    }
}
