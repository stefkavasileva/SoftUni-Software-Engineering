using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CakeTycoon
{
    static void Main(string[] args)
    {
        int amountOfCakes = int.Parse(Console.ReadLine());
        decimal flourNeeded = decimal.Parse(Console.ReadLine());
        long kgFlourAvailable = long.Parse(Console.ReadLine());
        long amountTruffles = long.Parse(Console.ReadLine());
        long priceTruffle = long.Parse(Console.ReadLine());

        decimal cakes = kgFlourAvailable / flourNeeded;

        if (cakes >= amountOfCakes)
        {
            decimal trufflesCost = amountTruffles * priceTruffle;
            decimal cakePrice = (trufflesCost / amountOfCakes) * 1.25m;
            Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
        }
        else
        {
            cakes = (int)cakes;
            decimal totalFlour = amountOfCakes * flourNeeded;
            decimal kgNeeded = totalFlour - kgFlourAvailable;
            Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", cakes, kgNeeded);
        }
    }
}

