namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;

    public class AddTagToCommand
    {
        // AddTagTo <albumName> <tag>
        public string Execute(string[] data)
        {
            var albumName = data[1];
            var tagName = data[2];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Name == albumName) || !context.Tags.Any(t => t.Name == tagName))
                {
                    throw new ArgumentException("Either tag or album do not exist!");
                }

                var album = new Album(albumName);
                var tag = new Tag(tagName);
                var albumTag = new AlbumTag { Album = album, Tag = tag };

                context.AlbumTags.Add(albumTag);
                context.SaveChanges();
            }

            return $"Tag {tagName} added to {albumName}!";
        }
    }
}
