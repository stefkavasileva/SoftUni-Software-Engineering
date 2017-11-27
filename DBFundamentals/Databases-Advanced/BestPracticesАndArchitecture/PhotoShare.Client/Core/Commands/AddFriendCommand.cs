using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class AddFriendCommand : Command
    {
        private const int DataLength = 3;

        // AddFriend <username1> <username2>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(AddFriendCommand)));
            }

            var firstUsername = data[1];
            var secondUsername = data[2];

            using (var context = new PhotoShareContext())
            {
                CheckUser(context, firstUsername);
                CheckUser(context, secondUsername);

                var firstUser = context.Users.Single(u => u.Username.Equals(firstUsername));

                if (!firstUser.Username.Equals(Session.User.Username))
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                var secondUser = context.Users.Single(u => u.Username.Equals(secondUsername));

                if (context.Friendships.Any(x =>
                    x.User.Id.Equals(firstUser.Id) && x.Friend.Id.Equals(secondUser.Id)))
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.UsersAreAlreadyFriends, secondUsername, firstUsername));
                }

                var friendship = new Friendship { User = firstUser, Friend = secondUser };

                context.Friendships.Add(friendship);
                context.SaveChanges();
            }

            return string.Format(Messages.AcceptUserToFriendList, firstUsername, secondUsername);
        }

        private void CheckUser(PhotoShareContext context, string username)
        {
            if (!context.Users.Any(x => x.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, username));
            }
        }
    }
}
