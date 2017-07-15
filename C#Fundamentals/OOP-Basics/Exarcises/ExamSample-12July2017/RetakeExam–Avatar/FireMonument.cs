public class FireMonument : Monument
{
    protected int FireAffinity { get; set; }

    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    public override string ToString()
    {
        return $"###Fire Monument: {base.Name}, Fire Affinity: {this.FireAffinity}";
    }


    public override int GetPowe()
    {
        return this.FireAffinity;
    }
}
