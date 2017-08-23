public class Hard : Mission
{
    private const int EnduranceRequiredValue = 80;

    public Hard(double scoreToComplete)
        : base(scoreToComplete)
    {
        base.EnduranceRequired = EnduranceRequiredValue;
    }
}

