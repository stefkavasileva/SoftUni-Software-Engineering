using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ParkingLot
{
    public class Startup
    {
        public static void Main()
        {
            var uniqueCarNumbers = new HashSet<string>();
            while (true)
            {
                var inputArgs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
                if (inputArgs[0] == "END") break;

                var direction = inputArgs[0];
                var carNumber = inputArgs[1];

                if (direction.Equals("IN"))
                {
                    uniqueCarNumbers.Add(carNumber);
                }
                else
                {
                    uniqueCarNumbers.Remove(carNumber);
                }
            }

            if (!uniqueCarNumbers.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var carNumber in uniqueCarNumbers.OrderBy(x=>x))
            {
                Console.WriteLine(carNumber);
            }
        }
    }
}
