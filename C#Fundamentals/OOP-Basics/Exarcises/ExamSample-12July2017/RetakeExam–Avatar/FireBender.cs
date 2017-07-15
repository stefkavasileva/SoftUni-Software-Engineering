public class FireBender : Bender
{
    protected double HeatAggression { get; set; }

    public FireBender(string name, int power, double heatAggression) 
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return base.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return $"###Fire Bender: {base.Name}, Power: {base.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }
}
