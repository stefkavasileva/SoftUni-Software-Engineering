public class Employee
{
    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string name, string position, string department, decimal salary)
    {
        this.name = name;
        this.position = position;
        this.department = department;
        this.salary = salary;
        this.email = "n/a";
        this.age = -1;
    }
}