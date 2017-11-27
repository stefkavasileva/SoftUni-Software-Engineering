using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagToCommand : Command
    {
        private const char TagPrefix = '#';
        private const int DataLength = 2;

        // AddTagTo <albumName> <tag>
        public override string Execute(string[] data)
        {
            if (data.Length < DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(AddFriendCommand)));
            }

            var albumName = data[1];
            var tagName = data[2];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Name == albumName) || !context.Tags.Any(t => t.Name == "#" + tagName))
                {
                    throw new ArgumentException(ErrorMessages.NonExistingTagOrAlbum);
                }

                var album = context.Albums.Single(a => a.Name.Equals(albumName));
                var tag = context.Tags.Single(t => t.Name.Equals(TagPrefix + tagName));

                var albumTag = new AlbumTag { Album = album, Tag = tag };

                context.AlbumTags.Add(albumTag);
                context.SaveChanges();
            }

            return string.Format(Messages.AddedTagToAlbum, tagName, albumName);
        }
    }
}
