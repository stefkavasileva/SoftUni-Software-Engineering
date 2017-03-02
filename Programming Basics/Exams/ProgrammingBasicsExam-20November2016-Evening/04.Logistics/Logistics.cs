using System;

public class Logistics
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int microbus = 0;
        int truck = 0;
        int train = 0;
        int totalLoad = 0;
        
        for (int i = 0; i < n; i++)
        {
            int load = int.Parse(Console.ReadLine());
            if (load <= 3)
            {
                microbus += load;
            }
            else if (load > 3 && load <= 11)
            {
                truck += load;
            }
            else
            {
                train += load;
            }

            totalLoad += load;
        }

        double average = ((microbus * 200.0) + (truck * 175.0) + (train * 120.0)) / totalLoad;

        Console.WriteLine($"{average:f2}");
        Console.WriteLine($"{((double)microbus / totalLoad) * 100.0:f2}%");
        Console.WriteLine($"{((double)truck / totalLoad) * 100.0:f2}%");
        Console.WriteLine($"{((double)train / totalLoad) * 100.0:f2}%");
    }
}
