using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
    }

    public int Length
    {
        get => this.length;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.length)} can not be a negative number");
            }

            this.length = value;
        }
    }

    public string Route
    {
        get => this.route;
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(this.route)} can not be null or empty string");
            }

            this.route = value;
        }
    }

    public int PrizePool
    {
        get => this.prizePool;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.prizePool)} can not be a negative number");
            }

            this.prizePool = value;
        }
    }

    public List<Car> Participants { get; set; }

    public abstract double GetPoint(Car car);

    public int GetMoney(int prizePool, int percentage)
    {
        return (prizePool * percentage) / 100;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var top = this.Participants.OrderByDescending(x => GetPoint(x)).Take(3).ToArray();
        var percentage = 50;

        if (top.Any())
        {
            sb.AppendLine($"{this.Route} - {this.Length}");
            for (int i = 0; i < top.Length; i++)
            {
                if (i == 1) percentage = 30;
                if (i == 2) percentage = 20;

                sb.AppendLine($"{i + 1}. {top[i].Brand} {top[i].Model} {GetPoint(top[i])}PP - ${this.GetMoney(this.prizePool, percentage)}");
            }
        }
        else
        {
            sb.AppendLine("Cannot start the race with zero participants");
        }

        return sb.ToString().Trim();
    }
}

