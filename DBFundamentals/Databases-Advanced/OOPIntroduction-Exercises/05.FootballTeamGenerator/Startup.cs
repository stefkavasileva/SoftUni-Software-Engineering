using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var teams = new List<Team>();

        var input = string.Empty;

        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];
            try
            {
                switch (command)
                {
                    case "Team":
                        teams.Add(new Team(tokens[1]));
                        break;

                    case "Add":
                        if (!teams.Any(t => t.Name == tokens[1]))
                        {
                            throw new ArgumentException(string.Format(ErrorMessages.NotExistingTeam,tokens[1]));
                        }
                        else
                        {
                            var currentTeam = teams.First(t => t.Name == tokens[1]);
                            currentTeam.AddPlayer(new Player(tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]),
                                int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7])));
                        }
                        break;

                    case "Remove":
                        var teamToRemove = teams.First(t => t.Name == tokens[1]);
                        teamToRemove.RemovePlayer(tokens[2]);
                        break;

                    case "Rating":
                        if (!teams.Any(t => t.Name == tokens[1]))
                        {
                            throw new ArgumentException(string.Format(ErrorMessages.NotExistingTeam,tokens[1]));
                        }
                        else
                        {
                            Console.WriteLine(teams.First(t => t.Name == tokens[1]).ToString());
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

