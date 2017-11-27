using System;
using PhotoShare.Client.Utilities;

namespace PhotoShare.Client.Core.Commands
{
    public class LogoutCommand : Command
    {
        public override string Execute(string[] data)
        {
            var currentlyLoggedUser = Session.User;

            if (currentlyLoggedUser == null)
            {
                throw new InvalidOperationException(ErrorMessages.LogoutNotAlowed);
            }

            Session.User = null;
            return string.Format(Messages.SuccessfullyLogout, currentlyLoggedUser.Username);
        }
    }
}
