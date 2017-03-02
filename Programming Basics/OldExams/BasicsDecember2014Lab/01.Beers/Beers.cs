using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Beers
{
    static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine().ToLower().Split();

        int totalBeers = 0;

        while (!inputLine[0].Equals("end"))
        {
            int count = int.Parse(inputLine[0]);
            string measure = inputLine[1];

            if (measure.Equals("stacks"))
            {
                totalBeers += count * 20;
            }
            else
            {
                totalBeers += count;
            }

            inputLine = Console.ReadLine().ToLower().Split();
        }

        int stacks = totalBeers / 20;
        int beers = totalBeers % 20;

        Console.WriteLine($"{stacks} stacks + {beers} beers");
    }
}

