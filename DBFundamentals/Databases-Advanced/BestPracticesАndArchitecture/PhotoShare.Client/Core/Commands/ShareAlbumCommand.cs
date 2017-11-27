using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class ShareAlbumCommand : Command
    {
        private const int DataLength = 4;

        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(ShareAlbumCommand)));
            }

            var albumId = int.Parse(data[1]);
            var username = data[2];
            var permission = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Id.Equals(albumId)))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistingAlbum, albumId));
                }

                if (!context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new ArgumentException(ErrorMessages.NonExistentUser, username);
                }

                bool isPermissionValid = Enum.TryParse(data[2], true, out Role permissionRole);

                if (isPermissionValid)
                {
                    throw new ArgumentException(ErrorMessages.InvalidPermission);
                }

                var user = context.Users.Single(u => u.Username.Equals(username));
                var album = context.Albums.Single(a => a.Id.Equals(albumId));

                user.AlbumRoles.Add(new AlbumRole { Album = album, User = user, Role = (Role)Enum.Parse(typeof(Role), permission) });
                context.SaveChanges();

                return string.Format(Messages.SharedAlbum, username, album.Name, permission);
            }
        }
    }
}
