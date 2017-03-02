using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FruitShop
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string day = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        decimal priceProduct = 0;

        if (day == "saturday" || day == "sunday")
        {
            switch (product)
            {
                case "banana":
                    priceProduct = 2.70m;
                    break;
                case "apple":
                    priceProduct = 1.25m;
                    break;
                case "orange":
                    priceProduct = 0.90m;
                    break;
                case "grapefruit":
                    priceProduct = 1.60m;
                    break;
                case "kiwi":
                    priceProduct = 3.00m;
                    break;
                case "pineapple":
                    priceProduct = 5.60m;
                    break;
                case "grapes":
                    priceProduct = 4.20m;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            decimal totalPrice = priceProduct * (decimal)quantity;

            Console.WriteLine("{0:f2}", totalPrice);
        }
        else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
        {
            switch (product)
            {
                case "banana":
                    priceProduct = 2.50m;
                    break;
                case "apple":
                    priceProduct = 1.20m;
                    break;
                case "orange":
                    priceProduct = 0.85m;
                    break;
                case "grapefruit":
                    priceProduct = 1.45m;
                    break;
                case "kiwi":
                    priceProduct = 2.70m;
                    break;
                case "pineapple":
                    priceProduct = 5.50m;
                    break;
                case "grapes":
                    priceProduct = 3.85m;
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            decimal totalPrice = priceProduct * (decimal)quantity;

            Console.WriteLine("{0:f2}", totalPrice);

        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

