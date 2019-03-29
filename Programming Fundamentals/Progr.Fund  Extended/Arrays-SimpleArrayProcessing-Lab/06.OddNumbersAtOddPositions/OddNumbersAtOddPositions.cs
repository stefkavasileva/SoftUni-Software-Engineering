using System;
using System.Linq;
using System.Text;

public class OddNumbersAtOddPositions
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var result = new StringBuilder();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 != 0 && numbers[i] % 2 != 0)
            {
                result.AppendLine($"Index {i} -> {numbers[i]}");
            }
        }

        Console.Write(result);
    }
}
