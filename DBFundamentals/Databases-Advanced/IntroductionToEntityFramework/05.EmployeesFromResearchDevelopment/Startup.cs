using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
                .Include(x => x.Department)
                .Where(x => x.Department.Name.Equals("Research and Development"))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    x.Department.Name,
                    x.Salary
                }).OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .ToList();

            employees.ForEach(x=> Console.WriteLine($"{x.FirstName} {x.LastName} from Research and Development - ${x.Salary:f2}"));
        }
    }
}

