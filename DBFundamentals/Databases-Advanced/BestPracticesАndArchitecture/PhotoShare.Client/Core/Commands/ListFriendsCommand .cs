using System;
using System.Linq;
using System.Text;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    public class ListFriendsCommand : Command
    {
        private const int DataLength = 2;

        // PrintFriendsList <username>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(ListFriendsCommand)));
            }

            var username = data[1];

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, username));
                }

                var user = context.Users.Single(u => u.Username.Equals(username));
                if (!user.FriendsAdded.Any())
                {
                    return Messages.NoFriendsMessage;
                }

                var sb = new StringBuilder();
                sb.AppendLine("Friends:");
                foreach (var friendship in user.FriendsAdded)
                {
                    sb.AppendLine($"-{friendship.Friend.Username}");
                }

                return sb.ToString().Trim();
            }
        }
    }
}
