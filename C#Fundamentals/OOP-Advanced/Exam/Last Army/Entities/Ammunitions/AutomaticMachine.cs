public class AutomaticMachine : Ammunition
{
    private const double WeightValue = 6.3;

    public AutomaticMachine(string name, double weight, double wearLevel)
        : base(name, weight, wearLevel)
    {
        this.WearLevel = WeightValue * 100;
    }
}
