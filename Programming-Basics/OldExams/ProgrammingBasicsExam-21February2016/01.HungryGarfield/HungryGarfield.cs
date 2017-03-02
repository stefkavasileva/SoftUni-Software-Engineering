using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HungryGarfield
{
    static void Main(string[] args)
    {
        decimal dollars = decimal.Parse(Console.ReadLine());
        decimal rateDollars = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal pizzaQuantity = decimal.Parse(Console.ReadLine());
        decimal lasagnaQuantity = decimal.Parse(Console.ReadLine());
        decimal sandwichQuantity = decimal.Parse(Console.ReadLine());
        decimal pizza = ((pizzaPrice / rateDollars) * pizzaQuantity);
        decimal lasagna = ((lasagnaPrice / rateDollars) * lasagnaQuantity);
        decimal sandwich = ((sandwichPrice / rateDollars) * sandwichQuantity);
        decimal moneyNeeded = pizza + lasagna + sandwich;

        if (moneyNeeded <= dollars)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", dollars - moneyNeed);
        }
        else
        {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", moneyNeed - dollars);
        }

    }
}

