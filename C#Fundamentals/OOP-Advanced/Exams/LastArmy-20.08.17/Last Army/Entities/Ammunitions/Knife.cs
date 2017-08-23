public class Knife : Ammunition
{
    private const double SpecialWeight = 0.4;

    public Knife()
        : base()
    {
        base.Weight = SpecialWeight;
    }
}
