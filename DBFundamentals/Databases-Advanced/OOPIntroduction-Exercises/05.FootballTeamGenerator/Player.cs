using System;

public class Player
{
    private int dribble;
    private int endurance;
    private string name;
    private int passing;
    private int shooting;
    private int sprint;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"A name should not be empty.");
            }

            this.name = value;
        }
    }

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public int Stats { get { return CalculateAverageStats(); } }

    private int Dribble
    {
        get { return this.dribble; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Dribble should be between 0 and 100.");
            }

            this.dribble = value;
        }
    }

    private int Endurance
    {
        get { return this.endurance; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Endurance should be between 0 and 100.");
            }

            this.endurance = value;
        }
    }

    private int Passing
    {
        get { return this.passing; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Passing should be between 0 and 100.");
            }

            this.passing = value;
        }
    }

    private int Shooting
    {
        get { return this.shooting; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Shooting should be between 0 and 100.");
            }

            this.shooting = value;
        }
    }

    private int Sprint
    {
        get { return this.sprint; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"Sprint should be between 0 and 100.");
            }

            this.sprint = value;
        }
    }

    private int CalculateAverageStats()
    {
        return (int)Math.Round((this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / (double)5);
    }
}
