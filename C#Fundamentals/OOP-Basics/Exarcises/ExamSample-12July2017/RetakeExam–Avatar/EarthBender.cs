public class EarthBender : Bender
{
    protected double GroundSaturation { get; set; }

    public EarthBender(string name, int power, double groundSaturation) 
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return base.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return $"###Earth Bender: {base.Name}, Power: {base.Power}, Ground Saturation: {this.GroundSaturation:f2}";
    }


}
