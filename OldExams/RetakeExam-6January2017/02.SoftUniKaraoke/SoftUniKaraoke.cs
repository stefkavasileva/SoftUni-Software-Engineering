using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main()
    {
        List<string> participants = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        List<string> availableSongs = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        var performances = new Dictionary<string, List<string>>();

        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("dawn"))
        {
            string[] inputLineArgs = inputLine.Split(',').Select(x => x.Trim()).ToArray();
            string singer = inputLineArgs[0];
            string song = inputLineArgs[1];
            string award = inputLineArgs[2];

            if (availableSongs.Contains(song) && participants.Contains(singer))
            {
                if (!performances.ContainsKey(singer))
                {
                    performances.Add(singer, new List<string>());
                }

                performances[singer].Add(award);
                performances[singer] = performances[singer].Distinct().ToList();
            }

            inputLine = Console.ReadLine();
        }

        performances = performances
            .OrderByDescending(x => x.Value.Count())
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        bool hasAward = false;

        foreach (var performance in performances)
        {
            Console.WriteLine($"{performance.Key}: {performance.Value.Count} awards");

            foreach (var award in performance.Value.OrderBy(x => x))
            {
                Console.WriteLine($"--{award}");
            }

            hasAward = true;
        }

        if (!hasAward)
        {
            Console.WriteLine("No awards");
        }
    }
}
