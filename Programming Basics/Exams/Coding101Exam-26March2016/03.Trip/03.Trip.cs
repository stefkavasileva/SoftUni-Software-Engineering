using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Trip
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine().ToLower();

        decimal amountSpent = 0;

        if (budget > 1000)
        {
            Console.WriteLine("Somewhere in Europe");

            amountSpent = budget * 0.9m;

            Console.WriteLine("Hotel - {0:f2}", amountSpent);
        }
        else if (budget <= 1000 && budget > 100)
        {
            Console.WriteLine("Somewhere in Balkans");

            if (season.Equals("summer"))
            {
                amountSpent = budget * 0.4m;
                Console.WriteLine("Camp - {0:f2}", amountSpent);
            }
            else
            {
                amountSpent = budget * 0.8m;
                Console.WriteLine("Hotel - {0:f2}", amountSpent);
            }
        }
        else
        {
            Console.WriteLine("Somewhere in Bulgaria");

            if (season.Equals("summer"))
            {
                amountSpent = budget * 0.3m;
                Console.WriteLine("Camp - {0:f2}", amountSpent);
            }
            else
            {
                amountSpent = budget * 0.7m;
                Console.WriteLine("Hotel - {0:f2}", amountSpent);
            }
        }
    }
}

