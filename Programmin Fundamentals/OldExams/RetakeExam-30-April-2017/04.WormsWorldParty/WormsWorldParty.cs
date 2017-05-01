using System;
using System.Collections.Generic;
using System.Linq;

public class WormsWorldParty
{
    public static void Main()
    {
        var teams = new Dictionary<string, Dictionary<string, long>>();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("quit"))
        {
            var totkens = inputLine
                .Split(new string[] { "->" }, StringSplitOptions.None)
                .Select(x => x.Trim())
                .ToArray();

            var teamName = totkens[1];
            var wormName = totkens[0];
            var score = long.Parse(totkens[2].Trim());

            var hasWorm = false;
            foreach (var kvp in teams)
            {
                if (kvp.Value.ContainsKey(wormName))
                {
                    hasWorm = true;
                }
            }

            if (!hasWorm)
            {
                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, long>());
                }

                teams[teamName].Add(wormName, 0);
                teams[teamName][wormName] += score;
            }

            inputLine = Console.ReadLine();
        }

        teams = teams
            .OrderByDescending(x => x.Value.Sum(y => y.Value))
            .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count())
            .ToDictionary(x => x.Key, x => x.Value);

        var count = 1;

        foreach (var team in teams)
        {
            Console.WriteLine($"{count}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");
            foreach (var worm in team.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{worm.Key} : {worm.Value}");
            }

            count++;
        }
    }
}
