public class Private : Soldier, IPrivate
{
    public Private(string id, string firstName, string lastName, double salary) 
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public double Salary { get; }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
    }
}
