using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Customer
{
    public string Name { get; set; }
    public Dictionary<string, int> ShopList { get; set; }

}

class AndreyAndBilliard
{
    static void Main(string[] args)
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

            Customer customer = new Customer();
            customer.ShopList = new Dictionary<string, int>();
            customer.Name = clientArgs[0];
            customer.ShopList.Add(productName, quantity);


            if (customers.Any(c => c.Name == clientArgs[0]))
            {
                Customer existingCustomer = customers.First(c => c.Name == clientArgs[0]);
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
            decimal custumerBill = 0.0m;
            Console.WriteLine(custumer.Name);

            foreach (var p in custumer.ShopList)
            {
                if (productsPrices.ContainsKey(p.Key))
                {
                    Console.WriteLine($"-- {p.Key} - {p.Value}");
                    custumerBill += productsPrices[p.Key] * p.Value;
                }
            }

            Console.WriteLine($"Bill: {custumerBill:f2}");
            totalBill += custumerBill;
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

