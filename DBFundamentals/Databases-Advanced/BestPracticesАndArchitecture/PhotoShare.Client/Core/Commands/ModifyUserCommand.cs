using System;
using System.Linq;
using System.Reflection;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    public class ModifyUserCommand : Command
    {
        private const int DataLength = 4;

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(ModifyUserCommand)));
            }

            var username = data[1];
            var propertyName = data[2];
            var newValue = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(x => x.Username == username))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, username));
                }

                var currentUser = context.Users.Single(u => u.Username.Equals(username));

                if (!currentUser.Username.Equals(Session.User.Username))
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                var propertyInfos = currentUser
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance);

                var invalidValueFormat = string.Format(ErrorMessages.InvalidPropertyValue, newValue);

                if (!propertyInfos.Any(p => p.Name.Equals(propertyName)))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.InvalidPropertyName, invalidValueFormat, propertyName));
                }

                if (propertyName.ToLower().Equals("password"))
                {
                    if (!newValue.Any(char.IsLower) || !newValue.Any(char.IsDigit))
                    {
                        throw new ArgumentException(string.Format(ErrorMessages.InvalidPassword, invalidValueFormat, Environment.NewLine));

                    }

                    currentUser.Password = newValue;
                }
                else if (propertyName.ToLower().Equals("borntown"))
                {
                    var newBornTown = context.Towns.Single(t => t.Name.Equals(newValue));

                    if (newBornTown is null)
                    {
                        throw new ArgumentException(string.Format(ErrorMessages.InvalidTown, invalidValueFormat, newBornTown));
                    }

                    currentUser.BornTown = newBornTown;
                }
                else if (propertyName.ToLower().Equals("currenttown"))
                {
                    var newCurrentTown = context.Towns.Single(t => t.Name.Equals(newValue));

                    if (newCurrentTown is null)
                    {
                        throw new ArgumentException(string.Format(ErrorMessages.InvalidTown, invalidValueFormat, newCurrentTown));
                    }

                    currentUser.CurrentTown = newCurrentTown;
                }
                else
                {
                    return string.Format(ErrorMessages.InvalidProperty, propertyName);
                }

                context.SaveChanges();
            }

            return string.Format(Messages.ModifiedUser, username, propertyName, newValue);
        }
    }
}