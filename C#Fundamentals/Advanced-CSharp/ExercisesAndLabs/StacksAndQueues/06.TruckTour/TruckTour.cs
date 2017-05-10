using System;
using System.Collections.Generic;
using System.Linq;

public class TruckTour
{
    public static void Main()
    {
        var count = int.Parse(Console.ReadLine());
        var pumps = new List<int[]>();

        for (int i = 0; i < count;i++)
        {
            pumps.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
        }

        for (int i = 0; i < count; i++)
        {
            if (IsSolution(count, pumps))
            {
                Console.WriteLine(i);
                break;
            }


            var startingPump = pumps[pumps.Count - 1];
            pumps.RemoveAt(pumps.Count - 1);
            pumps.Add(startingPump);
        }

    }

    public static bool IsSolution(int count, List<int[]> pumps)
    {
        int tankFuel = 0;
        bool foundAnswer = true;

        for (int i = 0; i < count; i++)
        {
            var currPump = pumps[pumps.Count - 1];
            pumps.RemoveAt(pumps.Count - 1);
            tankFuel += currPump[0] - currPump[1];
            if (tankFuel < 0)
            {
                foundAnswer = false;

                break;
            }

            pumps.Add(currPump);
        }

        return foundAnswer;
    }
}

