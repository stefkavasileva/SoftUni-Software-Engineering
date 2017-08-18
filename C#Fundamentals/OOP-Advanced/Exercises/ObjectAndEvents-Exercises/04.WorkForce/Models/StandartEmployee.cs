public class StandartEmployee : IEmployee
{
    public const int WorkHoursPerWeekConst = 40;

    public StandartEmployee(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public int WorkHoursPerWeek
    {
        get { return WorkHoursPerWeekConst; }
    }
}