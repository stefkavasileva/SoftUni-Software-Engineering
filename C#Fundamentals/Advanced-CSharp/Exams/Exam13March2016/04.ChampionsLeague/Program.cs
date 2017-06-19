using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.ChampionsLeague
{
    public class Program
    {
        public static void Main()
        {
            var teams = new Dictionary<string, List<string>>();
            var teamsWins = new Dictionary<string, long>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("stop"))
            {
                var tokens = inputLine.Split('|').Select(x => x.Trim()).ToArray();
                var firstTeam = tokens[0];
                var secondTeam = tokens[1];
                var scores = tokens[2].Split(':').Select(int.Parse).ToList();
                scores.AddRange(tokens[3].Split(':').Select(int.Parse));

                if (!teams.ContainsKey(firstTeam))
                {
                    teams.Add(firstTeam, new List<string>());
                }

                if (!teams.ContainsKey(secondTeam))
                {
                    teams.Add(secondTeam, new List<string>());
                }

                teams[firstTeam].Add(secondTeam);
                teams[secondTeam].Add(firstTeam);

                if (scores[0] + scores[3] > scores[1] + scores[2])
                {
                    AddScore(teamsWins, firstTeam);
                }
                else if (scores[0] + scores[3] < scores[1] + scores[2])
                {
                    AddScore(teamsWins, secondTeam);
                }
                else
                {

                    if (scores[1] > scores[3])
                    {
                        AddScore(teamsWins, secondTeam);
                    }
                    else
                    {
                        AddScore(teamsWins, firstTeam);
                    }
                }

                inputLine = Console.ReadLine();
            }

            teamsWins = teamsWins.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            var result = new StringBuilder();

            AddWinningTeam(teams, teamsWins, result);
            AddLoserTeams(teams, teamsWins, result);

            Console.Write(result);
        }

        private static void AddLoserTeams(Dictionary<string, List<string>> teams, Dictionary<string, long> teamsWins, StringBuilder result)
        {
            foreach (var team in teams.OrderBy(x => x.Key))
            {
                if (!teamsWins.ContainsKey(team.Key))
                {
                    result.AppendLine(team.Key);
                    result.AppendLine($"- Wins: 0");
                    result.AppendLine($"- Opponents: {string.Join(", ", team.Value.OrderBy(x => x))}");
                }
            }
        }

        private static void AddWinningTeam(Dictionary<string, List<string>> teams, Dictionary<string, long> teamsWins, StringBuilder result)
        {
            foreach (var currentTeam in teamsWins)
            {
                result.AppendLine(currentTeam.Key);
                result.AppendLine($"- Wins: {currentTeam.Value}");
                result.AppendLine($"- Opponents: {string.Join(", ", teams[currentTeam.Key].OrderBy(x => x))}");
            }
        }

        private static void AddScore(Dictionary<string, long> teamsWins, string teamName)
        {
            if (!teamsWins.ContainsKey(teamName))
            {
                teamsWins.Add(teamName, 0);
            }

            teamsWins[teamName]++;
        }
    }
}
