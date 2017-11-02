public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, string position, string department, decimal salary)
    {
        this.Name = name;
        this.Position = position;
        this.Department = department;
        this.Salary = salary;
        this.Email = "n/a";
        this.Age = -1;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public decimal Salary
    {
        get => this.salary;
        set => this.salary = value;
    }

    public string Position
    {
        get => this.position;
        set => this.position = value;
    }

    public string Department
    {
        get => this.department;
        set => this.department = value;
    }

    public string Email
    {
        get => this.email;
        set => this.email = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }
}