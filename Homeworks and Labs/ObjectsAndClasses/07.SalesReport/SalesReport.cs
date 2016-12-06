using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Sale
{
    public string Town { get; set; }

    public string Product { get; set; }

    public decimal Price { get; set; }

    public decimal Quantity { get; set; }

    public static List<Sale> ReadListOfSales()
    {
        int numOfSales = int.Parse(Console.ReadLine());
        List<Sale> sales = new List<Sale>();

        for (int i = 0; i < numOfSales; i++)
        {
            string[] saleInfo = Console.ReadLine().Split().ToArray();
            Sale sale = new Sale
            {
                Town = saleInfo[0],
                Product = saleInfo[1],
                Price = decimal.Parse(saleInfo[2]),
                Quantity = decimal.Parse(saleInfo[3])
            };
            sales.Add(sale);
        }
        return sales;
    }
}
    
class SalesReport
{
    static void Main(string[] args)
    {

        List<Sale> sales = Sale.ReadListOfSales();

        List<string> towns = sales.Select(s => s.Town).OrderBy(t => t).Distinct().ToList();

        foreach (var t in towns)
        {
            decimal salesForTown = sales.Where(s => s.Town == t).Sum(s => s.Price * s.Quantity);
            Console.WriteLine($"{t} -> {salesForTown:f2}");
        }
    }
}

