using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class UploadPictureCommand : Command
    {
        public const int DataLength = 4;

        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public override string Execute(string[] data)
        {
            if (data.Length != DataLength)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidCommandName, nameof(UploadPictureCommand)));
            }

            var albumName = data[1];
            var picTitle = data[2];
            var picFilePath = data[3];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(a => a.Name.Equals(albumName)))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.NonExistingAlbum, albumName));
                }

                var currentAlbum = context.Albums.Single(a => a.Name.Equals(albumName));
                var picture = new Picture(picTitle, picFilePath);
                picture.Album = currentAlbum;
                context.Pictures.Add(picture);

                context.SaveChanges();
            }

            return string.Format(Messages.AddedPicture, picTitle);
        }
    }
}
