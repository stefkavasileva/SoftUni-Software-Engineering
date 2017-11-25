namespace PhotoShare.Client.Core.Commands
{
    using Data;
    using System;
    using System.Linq;
    using Models;
    using Contracts;

    public class RegisterUserCommand : ICommand
    {
        // RegisterUser <username> <password> <repeat-password> <email>
        public string Execute(string[] data)
        {
            var username = data[0];
            var password = data[1];
            var repeatPassword = data[2];
            var email = data[3];

            if (password != repeatPassword)
            {
                throw new ArgumentException("Passwords do not match!");
            }

            using (var context = new PhotoShareContext())
            {
                if (context.Users.Any(u => u.Username == username || u.Email == email))
                {
                    throw new InvalidOperationException("Username [username] is already taken!");
                }

                var user = new User(username, password, email);

                context.Users.Add(user);
                context.SaveChanges();

                return "User " + user.Username + " was registered successfully!";
            }
        }
    }
}
