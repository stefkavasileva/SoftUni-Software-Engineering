public class AirMonument : Monument
{
    protected int AirAffinity { get; set; }

    public AirMonument(string name,int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public override string ToString()
    {
        return $"###Air Monument: {base.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override int GetPowe()
    {
       return this.AirAffinity;
    }
}
