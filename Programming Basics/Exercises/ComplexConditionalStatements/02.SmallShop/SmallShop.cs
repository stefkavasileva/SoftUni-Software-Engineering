using System;

public class SmallShop
{
    public static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        decimal price = 0;

        if (town == "sofia")
        {
            if (product == "coffee")
            {
                price = 0.50m;
            }
            else if (product == "water")
            {
                price = 0.80m;
            }
            else if (product == "beer")
            {
                price = 1.20m;
            }
            else if (product == "sweets")
            {
                price = 1.45m;
            }
            else
            {
                price = 1.60m;
            }
        }
        else if (town == "plovdiv")
        {
            if (product == "coffee")
            {
                price = 0.40m;
            }
            else if (product == "water")
            {
                price = 0.70m;
            }
            else if (product == "beer")
            {
                price = 1.15m;
            }
            else if (product == "sweets")
            {
                price = 1.30m;
            }
            else
            {
                price = 1.50m;
            }
        }
        else
        {
            if (product == "coffee")
            {
                price = 0.45m;
            }
            else if (product == "water")
            {
                price = 0.70m;
            }
            else if (product == "beer")
            {
                price = 1.10m;
            }
            else if (product == "sweets")
            {
                price = 1.35m;
            }
            else
            {
                price = 1.55m;
            }
        }

        decimal totalPrice = price * (decimal)quantity;

        Console.WriteLine((double)totalPrice);
    }
}