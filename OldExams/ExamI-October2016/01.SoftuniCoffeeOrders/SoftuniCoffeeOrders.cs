using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class SoftuniCoffeeOrders
{
    public static void Main()
    {
        var ordersCount = int.Parse(Console.ReadLine());

        var orderPrice = new List<decimal>();

        for (int i = 0; i < ordersCount; i++)
        {
            var capsulePrice = decimal.Parse(Console.ReadLine());
            var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InstalledUICulture);
            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var capsuleCount = long.Parse(Console.ReadLine());
            var picePerCapsules = (daysInMonth * capsuleCount) * capsulePrice;
            orderPrice.Add(picePerCapsules);
        }

        foreach (var order in orderPrice)
        {
            Console.WriteLine($"The price for the coffee is: ${order:f2}");
        }

        Console.WriteLine($"Total: ${orderPrice.Sum():f2}");
    }
}