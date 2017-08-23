public class AutomaticMachine : Ammunition
{
    private const double SpecialWeight = 6.3;

    public AutomaticMachine() 
        : base()
    {
        base.Weight = SpecialWeight;
    }
}