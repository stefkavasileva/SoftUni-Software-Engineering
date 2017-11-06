using System;
using System.Linq;
using P02_DatabaseFirst.Data;

public class Startup
{
    public static void Main()
    {
        var dbContext = new SoftUniContext();

        using (dbContext)
        {
            var employees = dbContext
                .Employees
                .OrderBy(x => x.EmployeeId)
                .ToList();

            employees.ForEach(x=> Console.WriteLine($"{x.FirstName} {x.LastName} {x.MiddleName} {x.JobTitle} {x.Salary:f2}"));
        }
        
    }
}

