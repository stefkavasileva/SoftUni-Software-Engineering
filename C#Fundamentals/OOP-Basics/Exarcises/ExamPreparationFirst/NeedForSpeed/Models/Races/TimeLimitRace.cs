using System.Collections.Generic;
using System.Text;

public class TimeLimitRace : Race
{
    public int GoldTime { get; set; }

    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
        : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    public override double GetPoint(Car car)
    {
        return (car.Horsepower / car.Acceleration) + car.Suspension + car.Durability;
    }

    public int GetTimePerformance(Car participant)
    {
        return this.Length * ((participant.Horsepower / 100) * participant.Acceleration);
    }

    public KeyValuePair<string, int> GetEarnedTime(Car participant)
    {
        var tp = this.GetTimePerformance(participant);

        if (tp <= this.GoldTime)
        {
            return new KeyValuePair<string, int>("Gold", this.PrizePool);
        }

        if (tp <= this.GoldTime + 15)
        {
            return new KeyValuePair<string, int>("Silver", this.PrizePool / 2);
        }

        if (tp > this.GoldTime + 15)
        {
            return new KeyValuePair<string, int>("Bronze", (int)(this.PrizePool * 0.3));
        }

        return new KeyValuePair<string, int>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{this.Participants[0].Brand} {this.Participants[0].Model} – {this.GetTimePerformance(this.Participants[0])} s.");
        sb.AppendLine(
            $"{this.GetEarnedTime(this.Participants[0]).Key} Time, ${this.GetEarnedTime(this.Participants[0]).Value}.");

        return sb.ToString().Trim();
    }
}

