public class MachineGun : Ammunition
{
    private const double WeightValue = 10.6;

    public MachineGun(string name, double weight, double wearLevel) 
        : base(name, weight, wearLevel)
    {
        base.WearLevel = WeightValue * 100;
    }
}
