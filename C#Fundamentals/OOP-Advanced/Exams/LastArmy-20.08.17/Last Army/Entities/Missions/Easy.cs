public class Easy : Mission
{
    private const int EnduranceRequiredValue = 20;

    public Easy(double scoreToComplete)
        : base(scoreToComplete)
    {
        base.EnduranceRequired = EnduranceRequiredValue;
    }
}

