namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using Contracts;

    public class AddFriendCommand : ICommand
    {
        // AddFriend <username1> <username2>
        public string Execute(string[] data)
        {
            var firstUsername = data[1];
            var secondUsername = data[2];

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(x => x.Username.Equals(firstUsername)))
                {
                    throw new ArgumentException($"{firstUsername} not found!");
                }

                if (!context.Users.Any(x => x.Username.Equals(secondUsername)))
                {
                    throw new ArgumentException($"{secondUsername} not found!");
                }

                if (context.Friendships.Any(x =>
                    x.User.Username.Equals(firstUsername) && x.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException($"{secondUsername} is already a friend to {firstUsername}");
                }

                var firstUser = context.Users.Single(u => u.Username.Equals(firstUsername));
                var secondUser = context.Users.Single(u => u.Username.Equals(secondUsername));

                var friendship = new Friendship { User = firstUser, Friend = secondUser };

                context.Friendships.Add(friendship);
                context.SaveChanges();
            }

            return $"Friend {firstUsername} added to {secondUsername}";
        }
    }
}
