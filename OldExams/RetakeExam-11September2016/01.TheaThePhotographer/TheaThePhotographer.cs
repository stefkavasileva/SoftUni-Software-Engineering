using System;

public class TheaThePhotographer
{
    public static void Main()
    {
        long amountOfPics = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        var filteredPics = (int)Math.Ceiling((amountOfPics * filterFactor) / 100.0);
        long totalPicsTime = amountOfPics * filterTime;
        long filteredPicsTime = filteredPics * uploadTime;
        long totalSeconds = totalPicsTime + filteredPicsTime;

        long days = totalSeconds / (60 * 60 * 24);
        long daysLeft = totalSeconds % (60 * 60 * 24);
        long hours = daysLeft / (60 * 60);
        long hoursLeft = daysLeft % (60 * 60);
        long minutes = hoursLeft / 60;
        long seconds = hoursLeft % 60;

        Console.WriteLine($"{days:0}:{hours:00}:{minutes:00}:{seconds:00}");
    }
}