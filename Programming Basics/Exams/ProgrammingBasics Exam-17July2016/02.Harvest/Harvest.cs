using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Harvest
{
    static void Main(string[] args)
    {
        int vineyardArea = int.Parse(Console.ReadLine());
        double neededVine = double.Parse(Console.ReadLine());
        int neededLitersVine = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double totalVine = vineyardArea * neededVine;
        double vine = 0.4 * totalVine / 2.5;

        if (vine >= neededLitersVine)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
            Console.WriteLine("{0} liters left -> {1} liters per person.",
               Math.Ceiling(vine - neededLitersVine), Math.Ceiling((vine - neededLitersVine) / workers));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededLitersVine - vine));
        }

    }
}

