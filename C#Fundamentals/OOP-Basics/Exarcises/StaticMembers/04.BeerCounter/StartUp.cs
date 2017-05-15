using System;
using System.Linq;

namespace _04.BeerCounter
{    
    public class StartUp
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var tokens = inputLine.Split().Select(int.Parse).ToArray();
                BeerCounter.BuyBeer(tokens[0]);
                BeerCounter.DrinkBeer(tokens[1]);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beersDrankCount}");
        }
    }
}
