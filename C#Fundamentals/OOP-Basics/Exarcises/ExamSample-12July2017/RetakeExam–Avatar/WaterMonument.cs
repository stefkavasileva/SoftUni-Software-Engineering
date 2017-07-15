public class WaterMonument : Monument
{
    protected int WaterAffinity { get; set; }

    public WaterMonument(string name, int waterAffinity)
           : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    public override string ToString()
    {
        return $"###Water Monument: {base.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override int GetPowe()
    {
        return this.WaterAffinity;
    }
}
