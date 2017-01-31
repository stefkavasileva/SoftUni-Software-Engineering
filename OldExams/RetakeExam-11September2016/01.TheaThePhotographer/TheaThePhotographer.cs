using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        long nPictures = long.Parse(Console.ReadLine());
        long filterSeconds = long.Parse(Console.ReadLine());
        long percentUseful = long.Parse(Console.ReadLine());
        long secondsUpload = long.Parse(Console.ReadLine());

        long timeFiltering = nPictures * filterSeconds;
        long nUseful = (long)Math.Ceiling((nPictures * percentUseful) / 100.0);

        long totalTime = secondsUpload * nUseful;

        long totalSec = timeFiltering + totalTime;
        long days = totalSec / 86400;
        long daysLeft = totalSec % 86400;
        long hours = daysLeft / 3600;
        long hoursLeft = daysLeft % 3600;
        long min = hoursLeft / 60;
        long sec = hoursLeft % 60;

        Console.WriteLine($"{days}:{hours:00}:{min:00}:{sec:00}");
    }
}
