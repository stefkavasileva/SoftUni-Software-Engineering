using System;
using System.Collections.Generic;

public class MelonsAndWatermelons
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int sequentialDays = int.Parse(Console.ReadLine());

        Dictionary<int, int> melons = new Dictionary<int, int>();
        melons.Add(2, 2);
        melons.Add(3, 1);
        melons.Add(5, 2);
        melons.Add(6, 2);

        Dictionary<int, int> watermelons = new Dictionary<int, int>();
        watermelons.Add(1, 1);
        watermelons.Add(3, 1);
        watermelons.Add(4, 2);
        watermelons.Add(5, 2);
        watermelons.Add(6, 1);

        int eatsMelons = 0;
        int eatsWatermelons = 0;
        int counter = day;

        for (int i = day; i < day + sequentialDays; i++)
        {
            if (counter > 7)
            {
                counter = 1;
            }
            else if (counter == 7)
            {
                counter++;
                continue;
            }

            if (melons.ContainsKey(counter))
            {
                eatsMelons += melons[counter];
            }

            if (watermelons.ContainsKey(counter))
            {
                eatsWatermelons += watermelons[counter];
            }

            counter++;
        }

        if (eatsMelons == eatsWatermelons)
        {
            Console.WriteLine($"Equal amount: {eatsMelons}");
        }
        else
        {
            int diff = Math.Abs(eatsMelons - eatsWatermelons);
            if (eatsWatermelons > eatsMelons)
            {
                Console.WriteLine($"{diff} more watermelons");
            }
            else
            {
                Console.WriteLine($"{diff} more melons");
            }
        }
    }
}
