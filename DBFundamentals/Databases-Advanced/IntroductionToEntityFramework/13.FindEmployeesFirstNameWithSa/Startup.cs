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
                .Where(x => x.FirstName.StartsWith("Sa"))
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.Salary,
                    x.JobTitle
                })
                .ToList();

            employees.ForEach(x=> Console.WriteLine($"{x.FirstName} {x.LastName} - {x.JobTitle} - (${x.Salary:f2})"));
        }
    }
}
