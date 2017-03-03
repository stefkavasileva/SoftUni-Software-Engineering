using System;
using System.Linq;

public class SudokuResults
{
    public static void Main()
    {
        int totalMin = 0;
        int totalSec = 0;
        int numOfGames = 0;

        for (;;)
        {
            string time = Console.ReadLine();
            if (time == "Quit")
            {
                break;
            }

            int[] minAndSec = time.Split(':').Select(int.Parse).ToArray();
            totalMin += minAndSec[0];
            totalSec += minAndSec[1];
            numOfGames++;
        }

        double totalTime = (totalMin * 60) + totalSec;
        double score = totalTime / numOfGames;

        if (score > 1440)
        {
            Console.WriteLine("Bronze Star");
        }
        else if (score > 720)
        {
            Console.WriteLine("Silver Star");
        }
        else
        {
            Console.WriteLine("Gold Star");
        }

        Console.WriteLine("Games - {0} \\ Average seconds - {1}", numOfGames, Math.Ceiling(score));
    }
}
