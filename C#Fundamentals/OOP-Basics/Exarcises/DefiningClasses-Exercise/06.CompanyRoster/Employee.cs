public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, string position, string department, decimal salary)
    {
        this.Name = name;
        this.Position = position;
        this.Department = department;
        this.Salary = salary;
        this.Email = "n/a";
        this.Age = -1;
    }
}