using System;

public class Player
{
    public const int MinStatValue = 0;
    public const int MaxStatValue = 100;

    public Player(string name, long endurance, long sprint, long dribble, long passing, long shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    private string name;
    private long endurance;
    private long sprint;
    private long dribble;
    private long passing;
    private long shooting;

    public string Name
    {
        get => this.name;
        set
        {
            if (string.IsNullOrEmpty(value) || value == " ")
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    private long Endurance
    {
        get => this.endurance;
        set
        {
            if (value < MinStatValue || value > MaxStatValue)
            {
                throw new ArgumentException($"{nameof(Endurance)} should be between {MinStatValue} and {MaxStatValue}.");
            }

            this.endurance = value;
        }
    }

    private long Sprint
    {
        get => this.sprint;
        set
        {
            if (value < MinStatValue || value > MaxStatValue)
            {
                throw new ArgumentException($"{nameof(Sprint)} should be between {MinStatValue} and {MaxStatValue}.");
            }

            this.sprint = value;
        }
    }

    private long Dribble
    {
        get => this.dribble;
        set
        {
            if (value < MinStatValue || value > MaxStatValue)
            {
                throw new ArgumentException($"{nameof(Dribble)} should be between {MinStatValue} and {MaxStatValue}.");
            }

            this.dribble = value;
        }
    }

    private long Passing
    {
        get => this.passing;
        set
        {
            if (value < MinStatValue || value > MaxStatValue)
            {
                throw new ArgumentException($"{nameof(Passing)} should be between {MinStatValue} and {MaxStatValue}.");
            }

            this.passing = value;
        }
    }

    private long Shooting
    {
        get => this.shooting;
        set
        {
            if (value < MinStatValue || value > MaxStatValue)
            {
                throw new ArgumentException($"{nameof(Shooting)} should be between {MinStatValue} and {MaxStatValue}.");
            }

            this.shooting = value;
        }
    }

    public double CalcPlayerState()
    {
        return (this.Dribble + this.Endurance + this.Passing + this.Shooting + this.Sprint) / 5.0;
    }

}

