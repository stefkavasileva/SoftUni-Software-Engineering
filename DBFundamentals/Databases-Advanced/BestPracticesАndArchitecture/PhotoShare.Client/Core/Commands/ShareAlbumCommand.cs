namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using Contracts;

    public class ShareAlbumCommand : ICommand
    {
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public string Execute(string[] data)
        {
            var albumId = int.Parse(data[1]);
            var username = data[2];
            var permission = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Id.Equals(albumId)))
                {
                    throw new ArgumentException($"Album {albumId} not found!");
                }

                if (!context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                bool isPermissionValid = Enum.TryParse(data[2], true, out Role permissionRole);

                if (isPermissionValid)
                {                 
                    throw new ArgumentException("Permission must be either “Owner” or “Viewer”!");
                }
                
                var user = context.Users.Single(u => u.Username.Equals(username));
                var album = context.Albums.Single(a => a.Id.Equals(albumId));

                user.AlbumRoles.Add(new AlbumRole { Album = album, User = user, Role = (Role)Enum.Parse(typeof(Role),permission) });
                context.SaveChanges();

                return $"Username {username} added to album {album.Name} ({permission})";
            }
        }
    }
}
