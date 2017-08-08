public class ReportCommand : Command
{
    [Inject]
    private readonly IRepository repository;

    public ReportCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        string output = this.repository.Statistics;
        return output;
    }
}