using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class SoftuniCoffeeOrders
{
    static void Main(string[] args)
    {
        int ordersCount = int.Parse(Console.ReadLine());

        List<decimal> orders = new List<decimal>();

        for (int i = 0; i < ordersCount; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            int days = DateTime.DaysInMonth(date.Year, date.Month);
            long capsulesCount = long.Parse(Console.ReadLine());

            decimal coffePrice = ((days * capsulesCount) * pricePerCapsule);
            orders.Add(coffePrice);
        }

        foreach (var order in orders)
        {
            Console.WriteLine("The price for the coffee is: ${0:f2}", order);
        }

        Console.WriteLine("Total: ${0:f2}", orders.Sum());
    }
}

