using System;
using System.Linq;

public class Last3ConsecutiveEqualStrings
{
    public static void Main()
    {
        var inputElements = Console.ReadLine().Split().Reverse().ToArray();

        var count = 1;
        var index = -1;
        for (int i = 0; i < inputElements.Length - 1; i++)
        {
            if (inputElements[i].Equals(inputElements[i + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count == 3)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(string.Concat(Enumerable.Repeat($"{inputElements[index]} ", 3)));
    }
}