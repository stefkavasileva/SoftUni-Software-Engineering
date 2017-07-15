using System.Linq;
using System.Text;

public class CircuitRace : Race
{
    public int Laps { get; set; }
    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    public override double GetPoint(Car car)
    {
        return (car.Horsepower / car.Acceleration) + car.Suspension + car.Durability;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length * this.Laps}");

        var top = this.Participants.OrderByDescending(x => GetPoint(x)).Take(4).ToArray();
        var percentage = 40;

        for (int i = 0; i < top.Length; i++)
        {
            if (i + 1 == 2) percentage = 30;
            if (i + 1 == 3) percentage = 20;
            if (i + 1 == 4) percentage = 10;

            top[i].Durability -= this.Laps + this.Length * Length;
            sb.AppendLine(
                $"{i + 1}. {top[i].Brand} {top[i].Model} {GetPoint(top[i])}PP - ${GetMoney(this.PrizePool, percentage)}");

        }

        return sb.ToString().Trim();
    }
}

