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
            var currentEmployee = dbContext
                .Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(x => x.EmployeeId == 147)
                .SingleOrDefault();

            var sb = new StringBuilder();
            sb.AppendLine($"{currentEmployee.FirstName} {currentEmployee.LastName} - {currentEmployee.JobTitle}");

            foreach (var currentEmployeeProject in currentEmployee.EmployeesProjects.OrderBy(x=>x.Project.Name))
            {
                sb.AppendLine(currentEmployeeProject.Project.Name);
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}

