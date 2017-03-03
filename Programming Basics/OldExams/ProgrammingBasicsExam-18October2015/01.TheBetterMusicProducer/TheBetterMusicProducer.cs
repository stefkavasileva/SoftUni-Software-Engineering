using System;

public class TheBetterMusicProducer
{
    public static void Main()
    {
        int soldAllbumInEurope = int.Parse(Console.ReadLine());
        decimal priceInEuro = decimal.Parse(Console.ReadLine());
        int soldAllbumInNorthAm = int.Parse(Console.ReadLine());
        decimal priceInDollars = decimal.Parse(Console.ReadLine());
        int soldAllbumInSouthAm = int.Parse(Console.ReadLine());
        decimal priceInPesos = decimal.Parse(Console.ReadLine());
        int numOfConcerts = int.Parse(Console.ReadLine());
        decimal profitInEuro = decimal.Parse(Console.ReadLine());

        decimal europeIncome = (soldAllbumInEurope * priceInEuro) * 1.94m;
        decimal northAmericaIncome = (soldAllbumInNorthAm * priceInDollars) * 1.72m;
        decimal southAmericaIncome = (soldAllbumInSouthAm * priceInPesos) / 332.74m;

        decimal allbumsIncome = europeIncome + northAmericaIncome + southAmericaIncome;
        allbumsIncome -= allbumsIncome * 0.35m;
        allbumsIncome -= allbumsIncome * 0.2m;

        decimal concertsProfit = (numOfConcerts * profitInEuro) * 1.94m;

        if (concertsProfit > 100000)
        {
            concertsProfit -= concertsProfit * 0.15m;
        }

        if (concertsProfit >= allbumsIncome)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", concertsProfit);
        }
        else
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", allbumsIncome);
        }
    }
}
