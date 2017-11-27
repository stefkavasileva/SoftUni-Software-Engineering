using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    public class LoginCommand : Command
    {
        private const int DataLength = 3;

        //Login <username> <password>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(LoginCommand)));
            }
            var username = data[1];

            using (var context = new PhotoShareContext())
            {
                var currentUser = context
                    .Users
                    .Single(u => u.Username.Equals(username));

                if (currentUser is null)
                {
                    throw new ArgumentException(ErrorMessages.InvalidUserOrPassword);
                }

                if (currentUser.IsDeleted != null && currentUser.IsDeleted.Value || Session.User != null)
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                currentUser.LastTimeLoggedIn = DateTime.Now;
                context.SaveChanges();
                Session.User = currentUser;
                return string.Format(Messages.LoggedUser, username);
            }
        }
    }
}
