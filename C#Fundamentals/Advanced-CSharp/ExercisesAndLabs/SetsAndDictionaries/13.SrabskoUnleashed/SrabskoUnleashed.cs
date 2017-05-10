using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class SrabskoUnleashed
{
    public static void Main()
    {
        string pattern = @"(([A-Za-z]+\s){1,})@(([A-Za-z]+\s){1,})(\d+)\s(\d+)";

        string inputLine = Console.ReadLine();

        var venues = new Dictionary<string, Dictionary<string, int>>();

        while (!inputLine.Equals("End"))
        {
            Regex reg = new Regex(pattern);
            Match match = reg.Match(inputLine);

            if (match.Success)
            {
                string singer = match.Groups[1].Value.Trim();
                string venue = match.Groups[3].Value.Trim();
                decimal ticketsPrice = decimal.Parse(match.Groups[5].Value);
                int ticketsCount = int.Parse(match.Groups[6].Value);

                int income = (int)(ticketsCount * ticketsPrice);

                if (!venues.ContainsKey(venue))
                {
                    venues.Add(venue, new Dictionary<string, int>());
                }

                if (!venues[venue].ContainsKey(singer))
                {
                    venues[venue].Add(singer, 0);
                }

                venues[venue][singer] += income;
            }

            inputLine = Console.ReadLine();
        }

        foreach (var venue in venues)
        {
            Console.WriteLine(venue.Key);

            foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}