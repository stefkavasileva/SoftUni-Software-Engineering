using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class RegisterUserCommand : Command
    {
        private const int DataLength = 5;

        // RegisterUser <username> <password> <repeat-password> <email>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(RegisterUserCommand)));
            }

            var username = data[1];
            var password = data[2];
            var repeatPassword = data[3];
            var email = data[4];

            if (Session.User != null)
            {
                throw new ArgumentException(ErrorMessages.InvalidCredentials);
            }

            using (var context = new PhotoShareContext())
            {

                if (context.Users.Any(u => u.Username == username || u.Email == email))
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.AlreadyTakenUser, username));
                }

                if (password != repeatPassword)
                {
                    throw new ArgumentException(ErrorMessages.PasswordDontMatch);
                }

                var user = new User(username, password, email);

                context.Users.Add(user);
                context.SaveChanges();

                return string.Format(Messages.RegisteredUser, username);
            }
        }
    }
}
