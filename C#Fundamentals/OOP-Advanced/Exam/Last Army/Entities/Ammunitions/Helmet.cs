public class Helmet: Ammunition
{
    private const double WeightValue = 2.3;

    public Helmet(string name, double weight, double wearLevel) 
        : base(name, weight, wearLevel)
    {
        this.WearLevel = WeightValue * 100;
    }
}
