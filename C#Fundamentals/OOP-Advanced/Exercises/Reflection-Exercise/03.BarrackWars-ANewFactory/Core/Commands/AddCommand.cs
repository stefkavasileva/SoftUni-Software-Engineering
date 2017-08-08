public class AddCommand : Command
{
    [Inject]
    private readonly IRepository repository;
    [Inject]
    private readonly IUnitFactory unitFactory;

    public AddCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        string unitType = this.Data[1];
        IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
        this.repository.AddUnit(unitToAdd);
        string output = $"{unitType} added!";
        return output;
    }
}