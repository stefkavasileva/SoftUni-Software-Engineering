public class Knife : Ammunition
{
    private const double WeightValue = 0.4;

    public Knife(string name, double weight, double wearLevel)
        : base(name, weight, wearLevel)
    {
        base.WearLevel = WeightValue * 100;
    }
}
