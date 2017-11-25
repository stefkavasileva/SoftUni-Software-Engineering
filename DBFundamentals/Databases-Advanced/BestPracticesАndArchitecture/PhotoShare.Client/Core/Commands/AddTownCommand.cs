namespace PhotoShare.Client.Core.Commands
{
    using Data;
    using Models;
    using System;
    using System.Linq;
    using Contracts;

    public class AddTownCommand :ICommand
    {
        // AddTown <townName> <countryName>
        public string Execute(string[] data)
        {
            var townName = data[1];
            var country = data[0];

            using (var context = new PhotoShareContext())
            {
                if (context.Towns.Any(t => t.Name.Equals(townName)))
                {
                    throw new ArgumentException($"Town {townName} was already added!");
                }

                var town = new Town(townName, country);

                context.Towns.Add(town);
                context.SaveChanges();

                return townName + " was added to database!";
            }
        }
    }
}
