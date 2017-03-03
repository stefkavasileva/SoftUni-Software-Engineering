using System;

public class TorrentPirate
{
    public static void Main()
    {
        int megabytes = int.Parse(Console.ReadLine());
        int moviePrice = int.Parse(Console.ReadLine());
        int wifeSprnding = int.Parse(Console.ReadLine());

        decimal downloadTime = megabytes / 2 / 60 / 60.0m;
        decimal priceForDownload = downloadTime * wifeSprnding;
        decimal numOfMovies = megabytes / 1500.0m;
        decimal cinemaPrice = numOfMovies * moviePrice;

        if (priceForDownload <= cinemaPrice)
        {
            Console.WriteLine("mall -> {0:f2}lv", priceForDownload);
        }
        else
        {
            Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
        }
    }
}
