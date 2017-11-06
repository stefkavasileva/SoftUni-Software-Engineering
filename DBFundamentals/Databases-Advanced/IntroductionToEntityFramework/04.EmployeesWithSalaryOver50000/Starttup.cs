using System;
using System.Linq;
using P02_DatabaseFirst.Data;

public class Starttup
{
    public static void Main()
    {
        var dbContext = new SoftUniContext();

        using (dbContext)
        {
            var employees = dbContext.Employees
                .Where(x => x.Salary > 50000)
                .Select(x => x.FirstName)
                .OrderBy(x=>x)
                .ToList();

            employees.ForEach(x=> Console.WriteLine(x));
        }
    }
}

