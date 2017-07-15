public class EarthMonument : Monument
{
    protected int EarthAffinity { get; set; }

    public EarthMonument(string name, int earthAffinity)
           : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public override string ToString()
    {
        return $"###Earth Monument: {base.Name}, Earth Affinity: {this.EarthAffinity}";
    }


    public override int GetPowe()
    {
        return this.EarthAffinity;
    }
}
