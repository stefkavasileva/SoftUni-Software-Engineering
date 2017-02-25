using System;
using System.Linq;

public class Altitude
{
    public static void Main()
    {
        var lineArgs = Console.ReadLine().Split().ToArray();

        var altitude = double.Parse(lineArgs[0]);

        for (int i = 1; i < lineArgs.Length - 1; i += 2)
        {
            var direction = lineArgs[i];
            var value = double.Parse(lineArgs[i + 1]);

            if (direction.Equals("up"))
            {
                altitude += value;
            }
            else
            {
                altitude -= value;
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
                return;
            }
        }

        Console.WriteLine($"got through safely. current altitude: {altitude}m");
    }
}