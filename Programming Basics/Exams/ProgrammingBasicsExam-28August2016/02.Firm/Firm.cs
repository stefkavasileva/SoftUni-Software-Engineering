using System;

public class Firm
{
    public static void Main()
    {
        var nHours = int.Parse(Console.ReadLine());
        var nDays = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());
        var inHours = (nDays * 8) + ((workers * 2) * nDays) - (0.1 * nDays * 8);

        if (inHours >= nHours)
        {
            var diff = 0.0;
            diff = inHours - nHours;
            Console.WriteLine($"Yes!{diff = Math.Floor(diff)} hours left.");
        }
        else
        {
            var diff = 0.0;
            diff = nHours - inHours;
            Console.WriteLine($"Not enough time!{diff = Math.Ceiling(diff)} hours needed.");
        }
    }
}
