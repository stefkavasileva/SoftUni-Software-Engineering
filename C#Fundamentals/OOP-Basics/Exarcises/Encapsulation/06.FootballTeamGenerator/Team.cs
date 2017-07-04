using System;
using System.Collections.Generic;
using System.Linq;
public class Team
{
    private string name;

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
            if (string.IsNullOrEmpty(value) || value == " ")
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    public List<Player> Players { get; set; }

    public long GetRating()
    {
        return (long)(this.Players.Sum(x => x.CalcPlayerState()));
    }

    public void AddPlayer(Player player)
    {
        this.Players.Add(player);
    }
}


