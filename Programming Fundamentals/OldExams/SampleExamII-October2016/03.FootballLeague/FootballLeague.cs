using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Team
{
    public string Name { get; set; }

    public int Score { get; set; }

    public long Points { get; set; }
}

public class FootballLeague
{
    public static void Main()
    {
        var teams = new List<Team>();

        var key = Regex.Escape(Console.ReadLine());
        var keyReg = new Regex($"{key}(.*?){key}.*{key}(.*?){key}.*?(\\d+):(\\d+)");

        var inputLine = Console.ReadLine();

        while (!inputLine.Equals("final"))
        {
            var match = keyReg.Match(inputLine);

            if (match.Success)
            {
                var firstTeamName = new string(match.Groups[1].Value.Reverse().ToArray()).ToUpper();
                var secondTeamName = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
                var firstTeamPoints = int.Parse(match.Groups[3].Value);
                var secondTeamPoints = int.Parse(match.Groups[4].Value);
                var firstTeamScore = 0;
                var secondTeamScore = 0;

                if (firstTeamPoints > secondTeamPoints)
                {
                    firstTeamScore = 3;
                }
                else if (secondTeamPoints > firstTeamPoints)
                {
                    secondTeamScore = 3;
                }
                else
                {
                    firstTeamScore = 1;
                    secondTeamScore = 1;
                }

                if (!teams.Any(t => t.Name == firstTeamName))
                {
                    Addteam(teams, firstTeamName, firstTeamPoints, firstTeamScore);
                }
                else
                {
                    UpdateTeamScore(teams, firstTeamName, firstTeamPoints, firstTeamScore);
                }

                if (!teams.Any(t => t.Name == secondTeamName))
                {
                    Addteam(teams, secondTeamName, secondTeamPoints, secondTeamScore);
                }
                else
                {
                    UpdateTeamScore(teams, secondTeamName, secondTeamPoints, secondTeamScore);
                }

            }

            inputLine = Console.ReadLine();
        }

        teams = teams.OrderByDescending(t => t.Score).ThenBy(t => t.Name).ToList();

        Console.WriteLine("League standings:");
        var count = 1;

        foreach (var team in teams)
        {
            Console.WriteLine($"{count}. {team.Name} {team.Score}");
            count++;
        }

        var topTeams = teams.OrderByDescending(t => t.Points).ThenBy(t => t.Name).Take(3).ToList();

        Console.WriteLine("Top 3 scored goals:");
        foreach (var topTeam in topTeams)
        {
            Console.WriteLine($"- {topTeam.Name} -> {topTeam.Points}");
        }
    }

    private static void UpdateTeamScore(List<Team> teams, string name, int points, int score)
    {
        teams.First(t => t.Name == name).Points += points;
        teams.First(t => t.Name == name).Score += score;
    }

    private static void Addteam(List<Team> teams, string teamName, int points, int score)
    {
        var team = new Team { Name = teamName, Points = points, Score = score };
        teams.Add(team);
    }
}

