public class PartTimeEmployee : IEmployee
{
    public const int WorkHoursPerWeekConst = 20;

    public PartTimeEmployee(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public int WorkHoursPerWeek
    {
        get { return WorkHoursPerWeekConst; }
    }
}