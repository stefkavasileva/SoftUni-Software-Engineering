using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class CreateAlbumCommand : Command
    {
        private const int DataLength = 5;
        private const char TagPrefix = '#';

        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public override string Execute(string[] data)
        {
            if (data.Length < DataLength)
            {
                throw new ArgumentException(ErrorMessages.InvalidCommandName);
            }

            var username = data[1];
            var albumTitle = data[2];
            var tags = data.Skip(4).ToList();

            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(u => u.Username == username))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistentUser, username));
                }

                if (context.Albums.Any(a => a.Name == albumTitle))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.ExistingAlbum, albumTitle));
                }

                var isColorExist = Enum.TryParse(data[3], true, out Color color);

                if (!isColorExist)
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistingColor, color));
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
                    throw new ArgumentException(ErrorMessages.InvalidTag);
                }


                var album = new Album(albumTitle, color);
                var currentUser = context.Users.Single(u => u.Username == username);

                if (!currentUser.Username.Equals(Session.User.Username))
                {
                    throw new InvalidOperationException(ErrorMessages.InvalidCredentials);
                }

                var albimRole = new AlbumRole { Role = Role.Owner, Album = album, User = currentUser };
                currentUser.AlbumRoles.Add(albimRole);

                foreach (string tag in tags)
                {
                    var currentTag = context.Tags.SingleOrDefault(t => t.Name.Equals(TagPrefix + tag));
                    var albumTag = new AlbumTag { Tag = currentTag, Album = album };

                    album.AlbumTags.Add(albumTag);
                }

                context.SaveChanges();
            }

            return string.Format(Messages.CreatedAlbum, albumTitle);
        }
    }
}
