using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftuniCoffeeOrders
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal totalPrice = 0.0m;

        for (int i = 0; i < n; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InstalledUICulture);
            decimal capsuleCount = decimal.Parse(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal capsulesPrice = ((daysInMonth * capsuleCount) * pricePerCapsule);
            totalPrice += capsulesPrice;
            Console.WriteLine($"The price for the coffee is: ${capsulesPrice:f2}");
        }

        Console.WriteLine($"Total: ${totalPrice:f2}");
    }
}

