using System;
using System.Collections.Generic;
using System.Linq;

public class TruckTour
{
    static int entries;
    static Queue<int[]> pumps;

    public static void Main(string[] args)
    {
        entries = int.Parse(Console.ReadLine());
        pumps = new Queue<int[]>();

        for (int entry = 0; entry < entries; entry++)
        {
            pumps.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
        }

        for (int entry = 0; entry < entries; entry++)
        {
            if (IsSolution())
            {
                Console.WriteLine(entry);
                break;
            }

            var startingPump = pumps.Dequeue();
            pumps.Enqueue(startingPump);
        }

    }

    static bool IsSolution()
    {
        var tankFuel = 0;
        var foundAnswer = true;

        for (int entry = 0; entry < entries; entry++)
        {
            var currPump = pumps.Dequeue();
            tankFuel += currPump[0] - currPump[1];

            if (tankFuel < 0)
            {
                foundAnswer = false;
            }

            pumps.Enqueue(currPump);
        }

        if (foundAnswer)
        {
            return true;
        }

        return false;
    }
}