using System;

public class BeerStock
{
    public static void Main()
    {
        ulong reservedBeers = ulong.Parse(Console.ReadLine());
        ulong beers = 0;
        ulong amount = 0;

        for (;;)
        {
            string comand = Console.ReadLine();
            if (comand == "Exam Over")
            {
                break;
            }

            string[] amountAndType = comand.Split(' ');

            amount = Convert.ToUInt64(amountAndType[0]);

            if (amountAndType[1] == "cases")
            {
                beers = beers + (amount * 24);
            }
            else if (amountAndType[1] == "sixpacks")
            {
                beers = beers + (amount * 6);
            }
            else if (amountAndType[1] == "beers")
            {
                beers = beers + amount;
            }
        }

        if (beers >= 100)
        {
            beers = beers - (beers / 100);
        }

        if (beers >= reservedBeers)
        {
            ulong beersLeft = beers - reservedBeers;
            ulong cases = beersLeft / 24;
            ulong sixpack = (beersLeft % 24) / 6;
            ulong beer = (beersLeft % 24) % 6;

            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beer);
        }
        else
        {
            ulong needBeer = reservedBeers - beers;
            ulong cases = needBeer / 24;
            ulong sixpack = (needBeer % 24) / 6;
            ulong beer = (needBeer % 24) % 6;

            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beer);
        }
    }
}