using System;
using System.Globalization;
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
            var employeeProjects = dbContext.Employees
                .Include(x=>x.Manager)
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .Where(x => x.EmployeesProjects.Any(y => y.Project.StartDate.Year >= 2001 || y.Project.StartDate.Year <= 2003))
                .Take(30)              
                .ToList();

            foreach (var employee in employeeProjects)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} – Manager: {employee.Manager.FirstName} {employee.Manager.LastName}");
                foreach (var project in employee.EmployeesProjects)
                {
                    var endDate = project.Project.EndDate is null
                        ? "not finished"
                        : project.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture);

                    Console.WriteLine($"--{project.Project.Name} - {project.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture)} - {endDate}");
                }
            }
        }
    }
}
