public class Helmet :Ammunition
{
    private const double SpecialWeight = 2.3;

    public Helmet()
        : base()
    {
        base.Weight = SpecialWeight;
    }
}
