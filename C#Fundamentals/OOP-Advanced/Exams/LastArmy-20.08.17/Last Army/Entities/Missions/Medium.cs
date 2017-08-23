public class Medium : Mission
{
    private const int EnduranceRequiredValue = 50;

    public Medium(double scoreToComplete)
        : base(scoreToComplete)
    {
        base.EnduranceRequired = EnduranceRequiredValue;
    }
}

