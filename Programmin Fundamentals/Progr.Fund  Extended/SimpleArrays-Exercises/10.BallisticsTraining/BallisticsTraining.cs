using System;
using System.Linq;

public class BallisticsTraining
{
    public static void Main()
    {
        var coordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var x = 0.0;
        var y = 0.0;

        var lineArgs = Console.ReadLine().Split().ToArray();
        for (int i = 0; i < lineArgs.Length - 1; i += 2)
        {
            var direction = lineArgs[i];
            var value = double.Parse(lineArgs[i + 1]);

            if (direction.Equals("up"))
            {
                y += value;
            }
            else if (direction.Equals("down"))
            {
                y -= value;
            }
            else if (direction.Equals("left"))
            {
                x -= value;
            }
            else
            {
                x += value;
            }
        }

        Console.WriteLine($"firing at [{x}, {y}]");

        if (x == coordinates.First() && y == coordinates.Last())
        {
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}