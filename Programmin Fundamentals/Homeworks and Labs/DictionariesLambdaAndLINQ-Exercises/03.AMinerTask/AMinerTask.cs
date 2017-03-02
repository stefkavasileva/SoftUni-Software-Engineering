using System;
using System.Collections.Generic;

public class AMinerTask
{
    public static void Main()
    {
        var resourceQuantity = new Dictionary<string, int>();

        while (true)
        {
            string resource = Console.ReadLine();

            if (resource.Equals("stop")) break;

            int quantity = int.Parse(Console.ReadLine());

            if (!resourceQuantity.ContainsKey(resource))
            {
                resourceQuantity.Add(resource, 0);
            }

            resourceQuantity[resource] += quantity;
        }

        foreach (var resource in resourceQuantity)
        {
            Console.WriteLine($"{resource.Key} -> {resource.Value}");
        }
    }
}