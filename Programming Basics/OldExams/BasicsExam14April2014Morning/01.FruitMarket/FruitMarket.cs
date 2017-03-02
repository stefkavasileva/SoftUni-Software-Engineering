using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FruitMarket
{
    static void Main(string[] args)
    {
        string dayOfWeek = Console.ReadLine().ToLower();
        decimal quantity1 = decimal.Parse(Console.ReadLine());
        string prodict1 = Console.ReadLine();
        decimal quantity2 = decimal.Parse(Console.ReadLine());
        string prodict2 = Console.ReadLine();
        decimal quantity3 = decimal.Parse(Console.ReadLine());
        string prodict3 = Console.ReadLine();

        Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
        productsPrice.Add("banana", 1.80m);
        productsPrice.Add("cucumber", 2.75m);
        productsPrice.Add("tomato", 3.20m);
        productsPrice.Add("orange", 1.60m);
        productsPrice.Add("apple", 0.86m);

        decimal price1 = productsPrice[prodict1] * quantity1;
        decimal price2 = productsPrice[prodict2] * quantity2;
        decimal price3 = productsPrice[prodict3] * quantity3;

        if (dayOfWeek.Equals("friday"))
        {
            price1 -= price1 * 0.1m;
            price2 -= price2 * 0.1m;
            price3 -= price3 * 0.1m;
        }
        else if (dayOfWeek.Equals("sunday"))
        {
            price1 -= price1 * 0.05m;
            price2 -= price2 * 0.05m;
            price3 -= price3 * 0.05m;
        }
        else if (dayOfWeek.Equals("tuesday"))
        {
            if (prodict1.Equals("banana") || prodict1.Equals("orange") || prodict1.Equals("apple"))
                price1 -= price1 * 0.2m;
            if (prodict2.Equals("banana") || prodict2.Equals("orange") || prodict2.Equals("apple"))
                price2 -= price2 * 0.2m;
            if (prodict3.Equals("banana") || prodict3.Equals("orange") || prodict3.Equals("apple"))
                price3 -= price3 * 0.2m;
        }
        else if (dayOfWeek.Equals("wednesday"))
        {
            if (prodict1.Equals("cucumber") || prodict1.Equals("tomato"))
                price1 -= price1 * 0.1m;
            if (prodict2.Equals("cucumber") || prodict2.Equals("tomato"))
                price2 -= price2 * 0.1m;
            if (prodict3.Equals("cucumber") || prodict3.Equals("tomato"))
                price3 -= price3 * 0.1m;
        }
        else if (dayOfWeek.Equals("thursday"))
        {
            if (prodict1.Equals("banana"))
                price1 -= price1 * 0.3m;
            if (prodict2.Equals("banana"))
                price2 -= price2 * 0.3m;
            if (prodict3.Equals("banana"))
                price3 -= price3 * 0.3m;
        }

        decimal totalPrice = price1 + price2 + price3;

        Console.WriteLine($"{totalPrice:f2}");
    }
}

