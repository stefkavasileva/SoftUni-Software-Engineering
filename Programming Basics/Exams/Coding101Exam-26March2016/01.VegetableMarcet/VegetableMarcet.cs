using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VegetableMarcet
{
    static void Main(string[] args)
    {
        decimal priceVegetables = decimal.Parse(Console.ReadLine());
        decimal priceFruits = decimal.Parse(Console.ReadLine());

        int kgVegetables = int.Parse(Console.ReadLine());
        int kgFruits = int.Parse(Console.ReadLine());

        decimal result = ((priceVegetables * kgVegetables) + (priceFruits * kgFruits)) / 1.94m;

        Console.WriteLine("{0}", result);
    }
}

