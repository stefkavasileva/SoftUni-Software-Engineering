using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TransportPrice
{
    static void Main(string[] args)
    {
        var km = Double.Parse(Console.ReadLine());
        var daytime = Console.ReadLine();
        double price = 0;
        if (km < 20)
        {
            if (daytime == "day")
            {
                price = 0.70 + (0.79 * km);
                Console.WriteLine(price);
            }
            else if (daytime == "night")
            {
                price = 0.70 + (km * 0.9);
                Console.WriteLine(price);
            }
        }
        else if (km >= 20 && km < 100)
        {
            price = 0.09 * km;
            Console.WriteLine(price);
        }
        else if (km >= 100)
        {
            price = 0.06 * km;
            Console.WriteLine(price);
        }
    }
}

