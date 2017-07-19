using System.Text;

public class Seat : ICar
{
    public string Model { get; }
    public string Color { get; }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Start()
    {
        throw new System.NotImplementedException();
    }

    public string Stop()
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model}");
        sb.AppendLine($"Engine start");
        sb.AppendLine($"Breaaak!");
        return sb.ToString().Trim();
    }
}
