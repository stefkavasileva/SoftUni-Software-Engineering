using System.Collections.Generic;

public class Department
{
    public string name;
    public List<Employee> employees;

    public Department(string name)
    {
        this.name = name;
        this.employees = new List<Employee>();
    }

    public Department()
    {

    }
}