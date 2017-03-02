using System;
using System.Text;

public class MaxCombination
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            for (int j = start; j <= end; j++)
            {
                if (count == max)
                {
                    Console.WriteLine(result);
                    return;
                }

                result.Append($"<{i}-{j}>");
                count++;
            }
        }

        Console.WriteLine(result);
    }
}
