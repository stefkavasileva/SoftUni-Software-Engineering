using System;
using System.Collections.Generic;

public class DrunkAni
{
    public static void Main()
    {
        int numOfCabins = int.Parse(Console.ReadLine());

        List<string> comands = new List<string>();
        int currentPosition = 0;
        string inputLine = Console.ReadLine();
        long numOfSteps = 0;

        while (!inputLine.Equals("Found a free one!"))
        {
            int steps = int.Parse(inputLine);
            int oldPosition = currentPosition;
            currentPosition = (currentPosition + steps) % numOfCabins;
            int diff = currentPosition - oldPosition;

            if (diff > 0)
            {
                string comand = "Go " + diff + " steps to the right, Ani.";
                comands.Add(comand);
                numOfSteps += diff;
            }
            else if (diff < 0)
            {
                diff = Math.Abs(diff);
                string comand = "Go " + diff + " steps to the left, Ani.";
                comands.Add(comand);
                numOfSteps += diff;
            }
            else
            {
                string comand = "Stay there, Ani.";
                comands.Add(comand);
            }

            inputLine = Console.ReadLine();
        }

        foreach (string comad in comands)
        {
            Console.WriteLine(comad);
        }

        Console.WriteLine("Moved a total of {0} steps.", numOfSteps);
    }
}
