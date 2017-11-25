namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Data;
    using Models;
    using Contracts;

    public class CreateAlbumCommand : ICommand
    {
        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(string[] data)
        {
            var username = data[1];
            var albumTitle = data[2];
            var bgColor = data[3];
            var tags = data.Skip(4).ToList();

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(u => u.Username == username))
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                if (context.Albums.Any(a => a.Name == albumTitle))
                {
                    throw new ArgumentException($"Album {albumTitle} exists!");
                }

                var colorNames = typeof(Color)
                    .GetProperties(BindingFlags.Public)
                    .Select(c => c.Name);

                if (!colorNames.Contains(bgColor))
                {
                    throw new ArgumentException($"Color {bgColor} not found!");
                }

                if (!tags.All(x => context.Tags.Any(t => t.Name.Equals(x))))
                {
                    throw new ArgumentException("Invalid tags!");
                }

                var color = (Color)Enum.Parse(typeof(Color), bgColor);
                var album = new Album(albumTitle, color);
                var currentUser = context.Users.Single(u => u.Username == username);

                var albimRole = new AlbumRole { Role = Role.Owner, Album = album, User = currentUser };
                currentUser.AlbumRoles.Add(albimRole);

                context.SaveChanges();
            }

            return $"Album {albumTitle} successfully created!";
        }
    }
}
