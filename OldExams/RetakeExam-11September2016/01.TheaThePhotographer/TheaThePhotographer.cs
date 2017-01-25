using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheaThePhotographer
{
    static void Main(string[] args)
    {
        long nPictures = long.Parse(Console.ReadLine());
        long filterSeconds = long.Parse(Console.ReadLine());
        long PercentUseful = long.Parse(Console.ReadLine());
        long secondsUpload = long.Parse(Console.ReadLine());


        long TimeFiltering = nPictures * filterSeconds;
        long nUseful = (long)Math.Ceiling((nPictures * PercentUseful) / 100.0);

        long totalTime = secondsUpload * nUseful;

        long totalSec = TimeFiltering + totalTime;
        long days = totalSec / 86400;
        long daysLeft = totalSec % 86400;
        long hours = daysLeft / 3600;
        long hoursLeft = daysLeft % 3600;
        long min = hoursLeft / 60;
        long sec = hoursLeft % 60;


        Console.WriteLine($"{days}:{hours:00}:{min:00}:{sec:00}"
    }
}

