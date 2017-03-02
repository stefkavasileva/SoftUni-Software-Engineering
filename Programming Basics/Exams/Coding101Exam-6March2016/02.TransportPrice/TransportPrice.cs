using System;

public class TransportPrice
{
    public static void Main()
    {
        var km = Double.Parse(Console.ReadLine());
        var daytime = Console.ReadLine();
        double price = 0;

        if (km < 20)
        {
            if (daytime == "day")
            {
                price = 0.70 + (0.79 * km);             
            }
            else if (daytime == "night")
            {
                price = 0.70 + (km * 0.9);
            }
        }
        else if (km >= 20 && km < 100)
        {
            price = 0.09 * km;
        }
        else if (km >= 100)
        {
            price = 0.06 * km;          
        }

        Console.WriteLine(price);
    }
}

