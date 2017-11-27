using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTownCommand : Command
    {
        private const int DataLength = 3;

        // AddTown <townName> <countryName>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(AddFriendCommand)));
            }

            var townName = data[1];
            var country = data[0];

            using (var context = new PhotoShareContext())
            {
                if (context.Towns.Any(t => t.Name.Equals(townName)))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.ExistingTown, townName));
                }

                var town = new Town(townName, country);

                context.Towns.Add(town);
                context.SaveChanges();

                return string.Format(Messages.AddedTown, townName);
            }
        }
    }
}
