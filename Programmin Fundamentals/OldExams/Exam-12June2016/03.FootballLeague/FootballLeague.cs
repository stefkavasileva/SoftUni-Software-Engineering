using System;
using System.Collections.Generic;
using System.Linq;

public class FootballLeague
{
    public static void Main()
    {
        string key = Console.ReadLine();

        string line = Console.ReadLine();

        Dictionary<string, List<long>> teams = new Dictionary<string, List<long>>();

        while (!line.ToUpper().Equals("FINAL"))
        {
            string[] tokens = line.Split();
            string[] teamsNames = new string[2];
            long[] goalsPoints = tokens[2].Split(':').Select(long.Parse).ToArray();
            long[] points = new long[2];

            GetPoints(goalsPoints, points);

            for (int i = 0; i < tokens.Length - 1; i++)
            {
                string teamName = tokens[i];
                int startIndex = teamName.IndexOf(key);
                int endIndex = teamName.LastIndexOf(key);
                teamName = teamName.Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] teamNameArr = teamName.ToCharArray();
                Array.Reverse(teamNameArr);
                teamName = string.Join(string.Empty, teamNameArr);
                teamsNames[i] = teamName.ToUpper();
                if (!teams.ContainsKey(teamsNames[i]))
                {
                    teams.Add(teamsNames[i], new List<long>());
                    teams[teamsNames[i]].Add(points[i]);
                    teams[teamsNames[i]].Add(goalsPoints[i]);
                }
                else
                {
                    teams[teamsNames[i]][0] += points[i];
                    teams[teamsNames[i]][1] += goalsPoints[i];
                }
            }

            line = Console.ReadLine();
        }

        PrintTeams(teams);
        PrintScoredGoals(teams);
    }

    private static void PrintScoredGoals(Dictionary<string, List<long>> teams)
    {
        Console.WriteLine("Top 3 scored goals:");
        foreach (var t in teams.OrderByDescending(t => t.Value[1]).ThenBy(t => t.Key).Take(3))
        {
            Console.WriteLine($"- {t.Key} -> {t.Value[1]}");
        }
    }

    private static void PrintTeams(Dictionary<string, List<long>> teams)
    {
        Console.WriteLine("League standings:");
        int count = 1;
        foreach (var t in teams.OrderByDescending(t => t.Value[0]).ThenBy(t => t.Key))
        {
            Console.WriteLine($"{count}. {t.Key} {t.Value[0]}");
            count++;
        }
    }

    private static void GetPoints(long[] goalsPoints, long[] points)
    {
        if (goalsPoints[0] == goalsPoints[1])
        {
            points[0] += 1;
            points[1] += 1;
        }
        else if (goalsPoints[0] > goalsPoints[1])
        {
            points[0] += 3;
        }
        else if (goalsPoints[1] > goalsPoints[0])
        {
            points[1] += 3;
        }
    }
}