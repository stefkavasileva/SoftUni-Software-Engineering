using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class AcceptFriendCommand : Command
    {
        private const int DataLength = 3;

        // AcceptFriend <username1> <username2>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(AcceptFriendCommand)));
            }

            var firstUsername = data[1];
            var secondUsername = data[2];

            using (var context = new PhotoShareContext())
            {
                var firstUser = context
                    .Users
                    .Include(u => u.FriendsAdded)
                    .ThenInclude(f => f.Friend)
                    .Include(u => u.AddedAsFriendBy)
                    .ThenInclude(f => f.Friend)
                    .Single(u => u.Username.Equals(firstUsername));

                if (firstUser is null)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, firstUsername));
                }

                if (!firstUser.Username.Equals(Session.User.Username))
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                var secondUser = context
                    .Users
                    .Include(u => u.FriendsAdded)
                    .ThenInclude(f => f.Friend)
                    .Include(u => u.AddedAsFriendBy)
                    .ThenInclude(f => f.Friend)
                    .SingleOrDefault(u => u.Username.Equals(secondUsername));

                if (secondUser is null)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, secondUsername));
                }

                if (firstUser.FriendsAdded.Any(f => f.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.UsersAreAlreadyFriends, secondUsername, firstUsername));
                }

                if (!firstUser.FriendsAdded.Any(f => f.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException(string.Format(ErrorMessages.NotAddedAsFriends, secondUsername, firstUsername));
                }

                var friendship = new Friendship
                {
                    User = firstUser,
                    Friend = secondUser
                };

                firstUser.FriendsAdded.Add(friendship);
                context.SaveChanges();

                return string.Format(Messages.AcceptUserToFriendList, firstUsername, secondUsername);
            }
        }
    }
}