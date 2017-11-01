using System;

public class Player
{
    private int dribble;
    private int endurance;
    private string name;
    private int passing;
    private int shooting;
    private int sprint;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
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

    public int Stats => CalculateAverageStats();

    private int Dribble
    {
        get => this.dribble;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(ErrorMessages.InvalidDribbleRange);
            }

            this.dribble = value;
        }
    }

    private int Endurance
    {
        get => this.endurance;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(ErrorMessages.InvalidEnduranceRange);
            }

            this.endurance = value;
        }
    }

    private int Passing
    {
        get => this.passing;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(ErrorMessages.InvalidPassingRange);
            }

            this.passing = value;
        }
    }

    private int Shooting
    {
        get => this.shooting;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(ErrorMessages.InvalidShootingRange);
            }

            this.shooting = value;
        }
    }

    private int Sprint
    {
        get => this.sprint;
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException(ErrorMessages.InvalidSprintRange);
            }

            this.sprint = value;
        }
    }

    private int CalculateAverageStats()
    {
        return (int)Math.Round((this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / (double)5);
    }
}
