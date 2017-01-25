using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FootballLeague
{
    static void Main(string[] args)
    {
        string key = Console.ReadLine();
        string footballMatch = Console.ReadLine();

        Dictionary<string, int> teams = new Dictionary<string, int>();
        Dictionary<string, int> teamsGoals = new Dictionary<string, int>();

        while (!footballMatch.Equals("final"))
        {
            int startIndex = footballMatch.IndexOf(key);
            int endIndex = footballMatch.IndexOf(key, startIndex + 1);
            string firstTeam = footballMatch.Substring(startIndex + key.Length, endIndex - key.Length - startIndex);
            firstTeam = new string(firstTeam.Reverse().ToArray()).ToUpper();

            startIndex = footballMatch.IndexOf(key, endIndex + 1);
            endIndex = footballMatch.IndexOf(key, startIndex + 1);
            string secondTeam = footballMatch.Substring(startIndex + key.Length, endIndex - key.Length - startIndex);
            secondTeam = new string(secondTeam.Reverse().ToArray()).ToUpper();

            int indexOfLastSpace = footballMatch.LastIndexOf(' ');
            int[] score = footballMatch.Substring(indexOfLastSpace)
                                .Split(':').Select(int.Parse).ToArray();

            AddTeamAndScore(teams, firstTeam, secondTeam, score);

            AddTeamsGoals(teamsGoals, firstTeam, secondTeam, score);

            footballMatch = Console.ReadLine();
        }

        teams = teams.OrderByDescending(x => x.Value)
                     .ThenBy(x => x.Key)
                     .ToDictionary(x => x.Key, x => x.Value);

        int count = 1;

        PrintTeams(count, teams);


        teamsGoals = teamsGoals.OrderByDescending(x => x.Value)
                     .ThenBy(x => x.Key)
                     .ToDictionary(x => x.Key, x => x.Value);

        PrintTopThreeTeams(teamsGoals);
    }

    private static void PrintTopThreeTeams(Dictionary<string, int> teamsGoals)
    {
        Console.WriteLine("Top 3 scored goals:");

        foreach (var teamg in teamsGoals.Take(3))
        {
            Console.WriteLine($"- {teamg.Key} -> {teamg.Value}");
        }
    }
    private static void PrintTeams(int count, Dictionary<string, int> teams)
    {
        Console.WriteLine("League standings:");

        foreach (var team in teams)
        {
            Console.WriteLine($"{count}. {team.Key} {team.Value}");
            count++;
        }
    }
    private static void AddTeamsGoals(Dictionary<string, int> teamsGoals, string firstTeam, string secondTeam, int[] score)
    {
        if (!teamsGoals.ContainsKey(firstTeam))
        {
            teamsGoals.Add(firstTeam, 0);
        }

        if (!teamsGoals.ContainsKey(secondTeam))
        {
            teamsGoals.Add(secondTeam, 0);
        }

        teamsGoals[firstTeam] += score[0];
        teamsGoals[secondTeam] += score[1];
    }

    private static void AddTeamAndScore(Dictionary<string, int> teams, string firstTeam, string secondTeam, int[] score)
    {
        if (!teams.ContainsKey(firstTeam))
        {
            teams.Add(firstTeam, 0);
        }

        if (!teams.ContainsKey(secondTeam))
        {
            teams.Add(secondTeam, 0);
        }

        if (score[0] > score[1])
        {
            teams[firstTeam] += 3;
        }
        else if (score[0] < score[1])
        {
            teams[secondTeam] += 3;
        }
        else
        {
            teams[firstTeam] += 1;
            teams[secondTeam] += 1;
        }
    }
}

