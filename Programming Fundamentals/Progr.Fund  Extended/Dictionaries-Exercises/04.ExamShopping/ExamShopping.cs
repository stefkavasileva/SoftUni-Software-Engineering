using System;
using System.Collections.Generic;
using System.Linq;

public class ExamShopping
{
    public static void Main()
    {
        var productsList = new Dictionary<string,int>();

        while (true)
        {
            var product = Console.ReadLine();
            if(product.Equals("shopping time")) break;

            var productArgs = product.Split().Select(p=>p.Trim()).ToArray();
            var productName = productArgs[1];
            var productQuantity =int.Parse(productArgs[2]);

            if (!productsList.ContainsKey(productName))
            {
                productsList.Add(productName,0);
            }

            productsList[productName] += productQuantity;
        }

        while (true)
        {
            var purchase = Console.ReadLine();
            if(purchase.Equals("exam time"))break;

            var purchaseArgs = purchase.Split().Select(p => p.Trim()).ToArray();
            var name = purchaseArgs[1];
            var quantity = int.Parse(purchaseArgs[2]);

            if (productsList.ContainsKey(name))
            {
                if (productsList[name] > 0)
                {
                    productsList[name] -= quantity;
                }
                else
                {
                    Console.WriteLine($"{name} out of stock");
                }

            }
            else
            {
                Console.WriteLine($"{name} doesn't exist");
            }
        }

        var leftProducts = productsList
            .Where(p => p.Value > 0)
            .ToDictionary(p => p.Key, p => p.Value);

        foreach (var kvp in leftProducts)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}