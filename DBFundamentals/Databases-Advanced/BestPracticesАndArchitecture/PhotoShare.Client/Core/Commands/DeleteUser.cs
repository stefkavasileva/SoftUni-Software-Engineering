using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    public class DeleteUserCommand : Command
    {
        private const int DataLength = 2;

        // DeleteUser <username>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(ErrorMessages.InvalidCommandName);
            }

            var username = data[1];

            using (var context = new PhotoShareContext())
            {
                var user = context.Users.Single(u => u.Username == username);
                if (user is null)
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.NonExistentUser, username));
                }

                if (!user.Username.Equals(Session.User.Username))
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                if (user.IsDeleted is null || user.IsDeleted.Value)
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.UserIsAlreadyDeleted, username));
                }

                user.IsDeleted = true;
                context.SaveChanges();

                return $"User {username} was deleted from the database!";
            }
        }
    }
}
