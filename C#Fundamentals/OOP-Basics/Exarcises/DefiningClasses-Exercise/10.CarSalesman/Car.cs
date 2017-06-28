using System.Text;

public class Car
{
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = "n/a";
        this.Color = "n/a";
    }

    public string Model { get; set; }
    public Engine Engine { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Model}:");
        sb.AppendLine($"  {this.Engine.Model}:");
        sb.AppendLine($"    Power: {this.Engine.Power}");
        sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
        sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
        sb.AppendLine($"  Weight: {this.Weight}");
        sb.AppendLine($"  Color: {this.Color}");

        return sb.ToString().Trim();
    }
}
