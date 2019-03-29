using System;
using System.Linq;

public class MostFrequentNumber
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxCount = 0;
        int mostFrequentNum = 0;

        foreach (var num in numbers)
        {
            int count = numbers.Count(x => x == num);
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentNum = num;
            }
        }

        Console.WriteLine(mostFrequentNum);
    }
}
