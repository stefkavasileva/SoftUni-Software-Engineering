using System;

public class VegetableMarcet
{
    public static void Main()
    {
        decimal priceVegetables = decimal.Parse(Console.ReadLine());
        decimal priceFruits = decimal.Parse(Console.ReadLine());

        int kgVegetables = int.Parse(Console.ReadLine());
        int kgFruits = int.Parse(Console.ReadLine());

        decimal result = ((priceVegetables * kgVegetables) + (priceFruits * kgFruits)) / 1.94m;

        Console.WriteLine("{0}", result);
    }
}
