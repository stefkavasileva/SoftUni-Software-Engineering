public class MachineGun : Ammunition
{
    private const double SpecialWeight = 10.6;

    public MachineGun()
        : base()
    {
        base.Weight = SpecialWeight;
    }
}
