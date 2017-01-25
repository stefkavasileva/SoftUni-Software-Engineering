using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class SoftUniCoffeeSupplies
{
    static void Main(string[] args)
    {
        //40/100
        string[] delimiters = Console.ReadLine().Split().ToArray();

        Dictionary<string, string> personOrders = new Dictionary<string, string>();
        Dictionary<string, int> coffeQuantity = new Dictionary<string, int>();


        string inputLine = Console.ReadLine();
        while (!inputLine.Equals("end of info"))
        {
            int startIndex = inputLine.LastIndexOf(delimiters[0]);
            if (startIndex > -1)
            {
                string personName = inputLine.Substring(0, startIndex);
                string coffeType = inputLine.Substring(startIndex + delimiters[0].Length);

                if (!personOrders.ContainsKey(personName))
                {
                    personOrders.Add(personName, string.Empty);
                }

                personOrders[personName] = coffeType;

            }
            else
            {
                startIndex = inputLine.LastIndexOf(delimiters[1]);
                string coffeType = inputLine.Substring(0, startIndex);
                string quantityAsStr = inputLine.Substring(startIndex + delimiters[0].Length);
                int quantity = int.Parse(quantityAsStr);

                if (!coffeQuantity.ContainsKey(coffeType))
                {
                    coffeQuantity.Add(coffeType, 0);
                }

                coffeQuantity[coffeType] += quantity;
            }


            inputLine = Console.ReadLine();
        }

        foreach (var order in personOrders)
        {
            if (!coffeQuantity.Keys.Contains(order.Value))
            {
                coffeQuantity.Add(order.Value, 0);
            }
        }

        string purchase = Console.ReadLine();

        while (!purchase.Equals("end of week"))
        {
            string[] purchaseArgs = purchase.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            string personName = purchaseArgs[0];
            int quantity = int.Parse(purchaseArgs[1].Trim());

            string coffeeType = personOrders[personName];
            coffeQuantity[coffeeType] -= quantity;

            purchase = Console.ReadLine();
        }

        coffeQuantity = coffeQuantity
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);


        foreach (var coffe in coffeQuantity.Where(x => x.Value <= 0))
        {
            Console.WriteLine($"Out of {coffe.Key}");
        }

        coffeQuantity = coffeQuantity
            .Where(x => x.Value > 0)
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        Console.WriteLine("Coffee Left:");
        foreach (var coffe in coffeQuantity)
        {
            Console.WriteLine($"{coffe.Key} {coffe.Value}");
        }

        Console.WriteLine("For:");

        personOrders = personOrders
            .OrderBy(x => x.Value)
            .ThenByDescending(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var person in personOrders)
        {
            if (coffeQuantity.ContainsKey(person.Value))
            {
                if (coffeQuantity[person.Value] > 0)
                {
                    Console.WriteLine($"{person.Key} {person.Value}");
                }

            }
        }
    }
}

