using System.Linq;
using System.Reflection;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ModifyUserCommand : ICommand
    {
        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {
            var username = data[1];
            var propertyName = data[2];
            var newValue = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(x => x.Username == username))
                {
                    throw new ArgumentException("User [username] not found!");
                }

                var propertyInfos = context.Users
                    .GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public);

                if (!propertyInfos.Any(p => p.Name.Equals(propertyName)))
                {
                    throw new ArgumentException($"Property {propertyName} not supported!");
                }

                var currentUser = context.Users.Single(u => u.Username == username);
                var currentProperty = currentUser.GetType().GetProperty(propertyName);

                if (currentProperty.Name.ToLower().Equals(nameof(currentUser.Username.ToLower)))
                {
                    throw new ArgumentException("Cannot change username");
                }

                if (currentProperty.Name.Equals(nameof(currentUser.Password))
                    && (!newValue.Any(x => char.IsDigit(x)) || !newValue.Any(x => char.IsLetter(x))))
                {
                    throw new ArgumentException("Invalid Password");
                }

                if (propertyName.Equals(nameof(currentUser.BornTown)) || propertyName.Equals(
                        nameof(currentUser.CurrentTown)))
                {
                    CheckForTheTown(context, newValue);
                }

                try
                {
                    currentProperty.SetValue(currentProperty, newValue);
                }
                catch (Exception exception)
                {
                    throw new ArgumentException($"Value {newValue} not valid.{exception.InnerException.Message}");
                }

                context.SaveChanges();

                return $"User {username} {propertyName} is {newValue}.";
            }
        }

        private void CheckForTheTown(PhotoShareContext context, string newValue)
        {
            if (!context.Towns.Any(t => t.Name == newValue))
            {
                throw new ArgumentException($"Town {newValue} not found!”");
            }
        }
    }
}
