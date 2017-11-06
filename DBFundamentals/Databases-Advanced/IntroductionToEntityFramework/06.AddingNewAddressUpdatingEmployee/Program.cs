using System;
using System.Linq;
using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;

public class Program
{
    public static void Main()
    {
        var dbContext = new SoftUniContext();

        using (dbContext)
        {
            var address = new Address();
            address.AddressText = "Vitoshka 15";
            address.TownId = 4;

            var employees = dbContext.Employees.Where(x => x.LastName.Equals("Nakov")).ToList();
            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].Address = address;
            }

            dbContext.SaveChanges();

            var addressNames = dbContext.Employees.OrderByDescending(x => x.AddressId).Take(10)
                .Select(x => x.Address.AddressText).ToList();
            addressNames.ForEach(x=>Console.WriteLine(x));
        }
    }
}

