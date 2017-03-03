using System;
using System.Collections.Generic;

public class TakeThePlaneDown
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int disctance = int.Parse(Console.ReadLine());
        int numOfPlanes = int.Parse(Console.ReadLine());

        List<string> messages = new List<string>();

        for (int i = 0; i < numOfPlanes; i++)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int deltaX = Math.Abs(x - x1);
            int deltaY = Math.Abs(y - y1);

            double distanceToPlane = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (distanceToPlane <= disctance)
            {
                string message = "You destroyed a plane at [" + x1 + "," + y1 + "]";

                messages.Add(message);
            }
        }

        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }
    }
}