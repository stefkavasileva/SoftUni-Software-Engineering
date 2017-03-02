using System;

public class BikeRace
{
    public static void Main()
    {
        int juniors = int.Parse(Console.ReadLine());
        int seniors = int.Parse(Console.ReadLine());
        string layout = Console.ReadLine();

        decimal income = 0;

        if (layout.Equals("trail"))
        {
            income = (juniors * 5.50m) + (seniors * 7m);
        }
        else if (layout.Equals("cross-country"))
        {
            income = (juniors * 8m) + (seniors * 9.50m);

            if (seniors + juniors >= 50)
            {
                income -= income * 0.25m;
            }
        }
        else if (layout.Equals("downhill"))
        {
            income = (juniors * 12.25m) + (seniors * 13.75m);
        }
        else if (layout.Equals("road"))
        {
            income = (juniors * 20m) + (seniors * 21.50m);
        }

        income -= income * 0.05m;

        Console.WriteLine($"{income:f2}");
    }
}
