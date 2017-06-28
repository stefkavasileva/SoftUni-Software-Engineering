using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CatLady
{
    public class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                var catInfo = inputLine.Split();
                var breed = catInfo[0];
                var name = catInfo[1];
                var property = double.Parse(catInfo[2]);

                var cat = new Cat(breed, name);
                if (breed.Equals("StreetExtraordinaire"))
                {
                    cat.Decibels = property;
                }
                else if (breed.Equals("Siamese"))
                {
                    cat.EarSize = property;
                }
                else
                {
                    cat.FurLength = property;
                }

                cats.Add(cat);
                inputLine = Console.ReadLine();
            }

            var catName = Console.ReadLine().Trim();
            var catResult = cats.FirstOrDefault(c => c.Name.Equals(catName));
            Console.WriteLine(catResult);
        }
    }
}
