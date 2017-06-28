public class Engine
{
    public string Model { get; set; }
    public string Power { get; set; }
    public string Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, string power)
    {
        this.Model = model;
        this.Power = power;
        this.Displacement = "n/a";
        this.Efficiency = "n/a";
    }
}