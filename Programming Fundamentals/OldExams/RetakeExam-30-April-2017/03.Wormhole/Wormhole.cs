using System;
using System.Linq;

public class Wormhole
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var steps = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 0)
            {
                steps++;
                continue;
            }

            var index = numbers[i];
            numbers[i] = 0;
            i = index - 1;
        }

        Console.WriteLine(steps);
    }
}