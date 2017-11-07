using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;

public class Startup
{
    public static void Main()
    {
        var dbContext = new SoftUniContext();
        using (dbContext)
        {
            var departments = dbContext
                .Departments
                .Include(x => x.Manager)
                .Include(x => x.Employees)
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name);

            var sb = new StringBuilder();
            foreach (var department in departments)
            {
                sb.AppendLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");
                foreach (var departmentEmployee in department.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
                {
                    sb.AppendLine($"{departmentEmployee.FirstName} {departmentEmployee.LastName} - {departmentEmployee.JobTitle}");
                }

                sb.AppendLine(new string('-', 10));
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

