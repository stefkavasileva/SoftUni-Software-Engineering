public abstract class Bender
{
    protected string Name { get; set; }
    private int power;

    public int Power
    {
        get => this.power;
        set => this.power = value;
    }

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public abstract double GetPower();

}
