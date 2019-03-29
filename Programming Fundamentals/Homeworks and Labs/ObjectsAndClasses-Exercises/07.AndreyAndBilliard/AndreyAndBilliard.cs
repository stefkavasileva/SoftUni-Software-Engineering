namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            long amount = long.Parse(Console.ReadLine());
            var productsPrices = new Dictionary<string, decimal>();

            GetProductAndPrices(amount, productsPrices);

            List<Customer> customers = new List<Customer>();

            string client = Console.ReadLine();
            while (!client.Equals("end of clients"))
            {
                string[] clientArgs = client.Split(new char[] { ',', '-' }).ToArray();
                string productName = clientArgs[1];
                int quantity = int.Parse(clientArgs[2]);

                var customer = new Customer(clientArgs[0], new Dictionary<string, int>());
                customer.ShopList.Add(productName, quantity);

                if (customers.Any(c => c.Name == clientArgs[0]))
                {
                    var existingCustomer = customers.First(c => c.Name == clientArgs[0]);
                    if (existingCustomer.ShopList.ContainsKey(productName))
                    {
                        existingCustomer.ShopList[productName] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[productName] = quantity;
                    }
                }
                else
                {
                    if (productsPrices.ContainsKey(productName))
                    {
                        customers.Add(customer);
                    }
                }

                client = Console.ReadLine();
            }

            decimal totalBill = 0.0m;
            customers = customers.OrderBy(x => x.Name).ToList();

            foreach (var custumer in customers)
            {
                Console.WriteLine(custumer.Name);

                foreach (var p in custumer.ShopList)
                {
                    if (productsPrices.ContainsKey(p.Key))
                    {
                        Console.WriteLine($"-- {p.Key} - {p.Value}");
                        custumer.Bill += productsPrices[p.Key] * p.Value;
                    }
                }

                Console.WriteLine($"Bill: {custumer.Bill:f2}");
                totalBill += custumer.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }

        private static void GetProductAndPrices(long amount, Dictionary<string, decimal> productsPrices)
        {
            for (int i = 0; i < amount; i++)
            {
                string[] productArgs = Console.ReadLine().Split('-').ToArray();
                string productName = productArgs[0];
                decimal productPrice = decimal.Parse(productArgs[1]);

                if (!productsPrices.ContainsKey(productName))
                {
                    productsPrices.Add(productName, productPrice);
                }
                else
                {
                    productsPrices[productName] = productPrice;
                }
            }
        }
    }
}