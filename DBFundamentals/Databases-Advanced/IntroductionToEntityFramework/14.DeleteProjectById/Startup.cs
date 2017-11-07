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
            var project = dbContext.Projects.Find(2);

            var employees = dbContext
                .Employees
                .Include(x => x.EmployeesProjects)
                .ThenInclude(x => x.Project)
                .ToList();

            foreach (var employee in employees)
            {
                foreach (var employeeProject in employee.EmployeesProjects.ToList())
                {
                    if (employeeProject.Project.Equals(project))
                    {
                        employee.EmployeesProjects.Remove(employeeProject);
                    }
                }
            }
        
            dbContext.Projects.Remove(project);

            dbContext.SaveChanges();

            var projects = dbContext.Projects.Select(x => x.Name).Take(10).ToList();
            projects.ForEach(x => Console.WriteLine(x));
        }
    }
}

