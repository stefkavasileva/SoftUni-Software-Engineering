namespace _05.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;

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

            File.WriteAllText("output.txt", string.Empty);

            foreach (var resource in resourceQuantity)
            {
                File.AppendAllText("output.txt", $"{resource.Key} -> {resource.Value}{Environment.NewLine}");
            }
        }
    }
}
