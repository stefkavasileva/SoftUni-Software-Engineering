public class RPG : Ammunition
{
    private const double WeightValue = 17.1;

    public RPG(string name, double weight, double wearLevel) 
        : base(name, weight, wearLevel)
    {
        base.WearLevel = WeightValue * 100;
    }
}
