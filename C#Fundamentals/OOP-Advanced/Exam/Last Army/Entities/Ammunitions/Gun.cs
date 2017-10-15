public class Gun : Ammunition
{
    private const double WeightValue = 1.4;

    public Gun(string name, double weight, double wearLevel) 
        : base(name, weight, wearLevel)
    {
        base.WearLevel = WeightValue * 100;
    }
}