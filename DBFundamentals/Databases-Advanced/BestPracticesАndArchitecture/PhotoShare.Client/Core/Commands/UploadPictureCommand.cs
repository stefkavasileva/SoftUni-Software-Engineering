namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Data;
    using Models;
    using Contracts;

    public class UploadPictureCommand : ICommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public string Execute(string[] data)
        {
            var albumName = data[1];
            var picTitle = data[2];
            var picFilePath = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Name.Equals(albumName)))
                {
                    throw new ArgumentException($"Album {albumName} not found!");
                }

                var currentAlbum = context.Albums.Single(a => a.Name.Equals(albumName));
                var picture = new Picture(picTitle, picFilePath);
                picture.Album = currentAlbum;
                context.Pictures.Add(picture);

                context.SaveChanges();
            }

            return $"Picture {picTitle} added to {albumName}!";
        }
    }
}
