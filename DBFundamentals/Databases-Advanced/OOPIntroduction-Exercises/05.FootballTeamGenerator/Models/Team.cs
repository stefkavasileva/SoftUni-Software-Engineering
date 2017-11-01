using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
    private string name;
    private IList<Player> players;

    public Team(string name)
    {
        this.Name = name;
        this.Players = new List<Player>();
    }

    public string Name
    {
        get => this.name;
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessages.InvalidName);
            }

            this.name = value;
        }
    }

    private IList<Player> Players
    {
        get => this.players;
        set => this.players = value;
    }

    public int Rating => CalculateTeamRating();

    private int CalculateTeamRating()
    {
        if (this.players.Any())
        {
            return (int)Math.Round(this.players.Average(p => p.Stats));
        }

        return 0;
    }

    public void AddPlayer(Player player) => this.players.Add(player);


    public void RemovePlayer(string player)
    {
        if (!this.players.Any(p => p.Name == player))
        {
            throw new ArgumentException(string.Format(ErrorMessages.NotExistingPlayer,player,this.name));
        }

        Player pl = this.players.FirstOrDefault(p => p.Name == player);
        this.players.Remove(pl);
    }

    public override string ToString()
    {
        return $"{this.name} - {this.Rating}";
    }
}