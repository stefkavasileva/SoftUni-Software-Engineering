public abstract class Ammunition : IAmmunition
{
    protected Ammunition(string name, double weight, double wearLevel)
    {
        this.Name = name;
        this.Weight = weight;
        this.WearLevel = wearLevel;
    }

    public string Name { get; protected set; }
    public double Weight { get; protected set; }
    public double WearLevel { get; protected set; }
    public bool WearLevelIsZero => this.WearLevel <= 0;

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}

