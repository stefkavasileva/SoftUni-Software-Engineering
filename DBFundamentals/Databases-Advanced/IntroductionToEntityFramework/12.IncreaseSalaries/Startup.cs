using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;

public class Startup
{
    public static void Main()
    {
        var departmentsName = new [] { "Engineering", "Tool Design", "Marketing", "Information Services" };
        var dbContext = new SoftUniContext();
        using (dbContext)
        {
            var employees = dbContext
                .Employees
                .Include(x => x.Department)
                .Where(x => departmentsName.Contains(x.Department.Name))
                .OrderBy(x=>x.FirstName)
                .ThenBy(x=>x.LastName)
                .ToList();

            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * 0.12m;
            }

            dbContext.SaveChanges();

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

