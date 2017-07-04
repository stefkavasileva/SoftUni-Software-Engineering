using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var teams = new List<Team>();

        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("END"))
        {
            var token = inputLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            if (token[0].Equals("Team"))
            {
                try
                {
                    teams.Add(new Team(token[1]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
            else if (token[0].Equals("Add"))
            {
                var currentTeam = teams.First(x => x.Name.Equals(token[1]));

                try
                {
                    currentTeam.AddPlayer(new Player(token[2], long.Parse(token[3]), long.Parse(token[4]),
                        long.Parse(token[5]), long.Parse(token[6]), long.Parse(token[7])));
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine($"Team {token[1]} does not exist.");
                }
            }
            else if (token[0].Equals("Remove"))
            {
                var currentTeam = teams.First(x => x.Name.Equals(token[1]));
                var playerName = token[2];

                try
                {
                    var currentPlayer = currentTeam.Players.First(x => x.Name.Equals(playerName));
                    currentTeam.Players.Remove(currentPlayer);
                }
                catch (Exception)
                {
                    Console.WriteLine($"Player {playerName} is not in {currentTeam.Name} team.");
                }
            }
            else if (token[0].Equals("Rating"))
            {
                try
                {
                    var rating = teams.First(x => x.Name.Equals(token[1])).GetRating();
                    Console.WriteLine($"{token[1]} - {rating}");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Team {token[1]} does not exist.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine($"{token[1]} - 0");
                }
            }

            inputLine = Console.ReadLine();
        }
    }
}

