namespace PhotoShare.Client.Core.Commands
{
    using Data;
    using System;
    using System.Linq;
    using Contracts;

    public class DeleteUser : ICommand
    {
        // DeleteUser <username>
        public string Execute(string[] data)
        {
            var username = data[1];
            using (var context = new PhotoShareContext())
            {
                var user = context.Users.Single(u => u.Username == username);
                if (user is null)
                {
                    throw new InvalidOperationException($"User with {username} was not found!");
                }

                if (user.IsDeleted is null || user.IsDeleted.Value)
                {
                    throw new InvalidOperationException($"User {username} is already deleted!");
                }

                user.IsDeleted = true;
                context.SaveChanges();

                return $"User {username} was deleted from the database!";
            }
        }
    }
}
