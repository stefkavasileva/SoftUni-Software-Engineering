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
                    throw new ArgumentException($"User {username} not found!");
                }

                var currentUser = context.Users.Single(u => u.Username.Equals(username));

                var propertyInfos = currentUser
                    .GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance);

                var exeption = $"Value {newValue} not valid.{Environment.NewLine}";

                if (!propertyInfos.Any(p => p.Name.Equals(propertyName)))
                {
                    throw new ArgumentException($"{exeption}Property {propertyName} not supported!");
                }

                if (propertyName.ToLower().Equals("password"))
                {
                    if (!newValue.Any(char.IsLower) || !newValue.Any(char.IsDigit))
                    {
                        throw new ArgumentException(
                            $"Value {newValue} not valid. Password must include a lower letter and a digit.{Environment.NewLine}Invalid Password");

                    }

                    currentUser.Password = newValue;
                }
                else if (propertyName.ToLower().Equals("borntown"))
                {
                    var newBornTown = context.Towns.Single(t => t.Name.Equals(newValue));

                    if (newBornTown is null)
                    {
                        throw new ArgumentException(
                            $"Value {newValue} not valid.{Environment.NewLine}Town {newValue} not found!");
                    }

                    currentUser.BornTown = newBornTown;
                }
                else if (propertyName.ToLower().Equals("currenttown"))
                {
                    var newCurrentTown = context.Towns.Single(t => t.Name.Equals(newValue));

                    if (newCurrentTown is null)
                    {
                        throw new ArgumentException(
                            $"Value {newValue} not valid.{Environment.NewLine}Town {newValue} not found!");
                    }

                    currentUser.CurrentTown = newCurrentTown;
                }
                else
                {
                    return $"Property {propertyName} not supported!";
                }


                context.SaveChanges();
            }

            return $"User {username} {propertyName} is {newValue}.";
        }


        private void CheckForTheTown(PhotoShareContext context, string newValue)
        {
            if (!context.Towns.Any(t => t.Name == newValue))
            {
                throw new ArgumentException(
                    $"Value {newValue} not valid.{Environment.NewLine}Town {newValue} not found!");
            }
        }
    }
}