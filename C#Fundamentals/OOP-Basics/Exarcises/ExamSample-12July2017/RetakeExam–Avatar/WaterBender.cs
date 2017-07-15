public class WaterBender : Bender
{
    protected double WaterClarity { get; set; }

    public WaterBender(string name, int power,double waterClarity) 
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override double GetPower()
    {
        return base.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"###Water Bender: {base.Name}, Power: {base.Power}, Water Clarity: {this.WaterClarity:f2}";
    }
}
