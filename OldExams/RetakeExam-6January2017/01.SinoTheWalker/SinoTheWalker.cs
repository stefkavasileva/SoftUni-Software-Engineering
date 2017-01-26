using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class SinoTheWalker
{
    static void Main(string[] args)
    {
        string leavesTimeAsStr = Console.ReadLine();

        DateTime leavesTime = DateTime.ParseExact(leavesTimeAsStr, "HH:mm:ss", CultureInfo.InvariantCulture);

        int steps = int.Parse(Console.ReadLine()) % 86400;
        int timeInSeconds = int.Parse(Console.ReadLine()) % 86400;

        int walkSeconds = steps * timeInSeconds;

        leavesTime = leavesTime.AddSeconds(walkSeconds);

        Console.WriteLine($"Time Arrival: {leavesTime.ToString("HH:mm:ss")}");
    }
}

