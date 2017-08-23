public class Gun : Ammunition
{
    private const double SpecialWeight = 6.3;

    public Gun()
        : base()
    {
        base.Weight = SpecialWeight;
    }
}
