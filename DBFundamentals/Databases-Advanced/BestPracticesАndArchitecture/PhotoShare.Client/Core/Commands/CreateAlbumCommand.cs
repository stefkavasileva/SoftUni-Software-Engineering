namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
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

                var isColorExist = Enum.TryParse(data[3], true, out Color color);

                if (!isColorExist)
                {
                    throw new ArgumentException($"Color {bgColor} not found!");
                }

                var isValidTag = false;
                foreach (var tag in tags)
                {
                    foreach (var contextTag in context.Tags)
                    {
                        var currentTag = new string(contextTag.Name.ToCharArray().Skip(1).ToArray());
                        if (tag.Equals(currentTag))
                        {
                            isValidTag = true;
                            break;
                        }
                    }

                    if (isValidTag) break;
                }

                if (!isValidTag)
                {
                    throw new ArgumentException("Invalid tags!");
                }


                var album = new Album(albumTitle, color);
                var currentUser = context.Users.Single(u => u.Username == username);

                var albimRole = new AlbumRole { Role = Role.Owner, Album = album, User = currentUser };
                currentUser.AlbumRoles.Add(albimRole);

                foreach (string tag in tags)
                {
                    var currentTag = context.Tags.SingleOrDefault(t => t.Name.Equals("#" + tag));
                    var albumTag = new AlbumTag { Tag = currentTag, Album = album };

                    album.AlbumTags.Add(albumTag);
                }

                context.SaveChanges();
            }

            return $"Album {albumTitle} successfully created!";
        }
    }
}
