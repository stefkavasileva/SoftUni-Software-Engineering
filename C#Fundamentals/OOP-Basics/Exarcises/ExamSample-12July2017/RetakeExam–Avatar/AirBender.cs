public class AirBender : Bender
{
    protected double AerialIntegrity { get; set; }

    public AirBender(string name, int power, double aerialIntegrity)
          : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return base.Power * this.AerialIntegrity;
    }

    public override string ToString()
    {
        return $"###Air Bender: {base.Name}, Power: {base.Power}, Aerial Integrity: {this.AerialIntegrity:f2}";
    }


}
