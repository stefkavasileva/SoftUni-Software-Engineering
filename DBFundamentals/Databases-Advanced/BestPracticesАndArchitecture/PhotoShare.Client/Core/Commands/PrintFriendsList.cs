namespace PhotoShare.Client.Core.Commands
{
    using System;
    using Contracts;
    using System.Linq;
    using System.Text;
    using Data;

    public class PrintFriendsList : ICommand
    { 
        // PrintFriendsList <username>
        public string Execute(string[] data)
        {
            var username = data[1];

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                var user = context.Users.Single(u => u.Username.Equals(username));
                if (!user.FriendsAdded.Any())
                {
                    return "No friends for this user. :(";
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
