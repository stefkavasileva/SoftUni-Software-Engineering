namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Contracts;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class AcceptFriendCommand : ICommand
    {
        // AcceptFriend <username1> <username2>
        public string Execute(string[] data)
        {
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
                    throw new ArgumentException($"{firstUsername} not found!");
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
                    throw new ArgumentException($"{secondUsername} not found!");
                }

                if (firstUser.FriendsAdded.Any(f => f.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException($"{secondUser} is already a friend to {firstUsername}!");
                }

                if (!firstUser.FriendsAdded.Any(f => f.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException($"{secondUsername} has not added {firstUsername} as a friend!");
                }

                var friendship = new Friendship
                {
                    User = firstUser,
                    Friend = secondUser
                };

                firstUser.FriendsAdded.Add(friendship);
                context.SaveChanges();

                return $"{firstUsername} accepted {secondUsername} as a friend.";
            }
        }
    }
}