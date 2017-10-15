public class NightVision : Ammunition
{
    private const double WeightValue = 0.8;

    public NightVision(string name, double weight, double wearLevel) 
        : base(name, weight, wearLevel)
    {
        base.WearLevel = WeightValue * 100;
    }
}