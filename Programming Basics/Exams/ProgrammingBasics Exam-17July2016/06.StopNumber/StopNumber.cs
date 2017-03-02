using System;
using System.Collections.Generic;

public class StopNumber
{
    public static void Main()
    {
        int fisrtNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int stopNum = int.Parse(Console.ReadLine());

        List<int> specialNums = new List<int>();

        for (int i = secondNum; i >= fisrtNum; i--)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                if (i == stopNum)
                {
                    break;
                }

                specialNums.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", specialNums));
    }
}

