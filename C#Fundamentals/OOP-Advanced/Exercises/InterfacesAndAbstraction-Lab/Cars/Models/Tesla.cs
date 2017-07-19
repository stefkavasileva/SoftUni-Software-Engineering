using System.Text;

public class Tesla :ICar,IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Model { get; }
    public string Color { get; }
    public int Battery { get; }

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
        sb.AppendLine($"{this.Color} {GetType().Name} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine($"Engine start");
        sb.AppendLine($"Breaaak!");
        return sb.ToString().Trim();
    }
}
