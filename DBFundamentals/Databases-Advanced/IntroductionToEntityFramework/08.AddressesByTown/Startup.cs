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
            var adresses = dbContext
                .Addresses
                .Include(x=>x.Town)
                .Include(x=>x.Employees)
                .OrderByDescending(x => x.Employees.Count)
                .ThenBy(x => x.Town.Name)
                .ThenBy(x => x.AddressText)
                .Take(10)
                .ToList();

            adresses.ForEach(x=> Console.WriteLine($"{x.AddressText}, {x.Town.Name} - {x.Employees.Count} employees"));
        }
    }
}
