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
            var townToBeDeletedName = Console.ReadLine();
            var addressesFromTheTargetTown = dbContext
                .Addresses
                .Where(a => a.Town.Name.Equals(townToBeDeletedName))
                .ToList();

            foreach (var employee in dbContext.Employees)
            {
                if (addressesFromTheTargetTown.Contains(employee.Address))
                {
                    employee.Address = null;
                }
            }

            dbContext.Addresses.RemoveRange(addressesFromTheTargetTown);

            var townToBeDeleted = dbContext.Towns.SingleOrDefault(t => t.Name.Equals(townToBeDeletedName));
            dbContext.Towns.Remove(townToBeDeleted);

            dbContext.SaveChanges();

            var removedAddressesCount = addressesFromTheTargetTown.Count;
            var addressSingleOrPlural = removedAddressesCount > 1 ? "addresses" : "address";
            var wasWere = removedAddressesCount > 1 ? "were" : "was";

            Console.WriteLine($"{removedAddressesCount} {addressSingleOrPlural} in {townToBeDeletedName} {wasWere} deleted");
        }
    }
}

