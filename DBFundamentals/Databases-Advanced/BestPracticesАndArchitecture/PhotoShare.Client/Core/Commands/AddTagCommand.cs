using System;
using System.Linq;
using PhotoShare.Client.Utilities;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    public class AddTagCommand : Command
    {
        private const int DataLength = 1;
        // AddTag <tag>
        public override string Execute(string[] data)
        {
            if (data.Length == DataLength)
            {
                throw new ArgumentException(ErrorMessages.InvalidCommandName);
            }

            var tagName = data[1].ValidateOrTransform();

            using (var context = new PhotoShareContext())
            {
                if (context.Tags.Any(t => t.Name == tagName))
                {
                    throw new ArgumentException(string.Format(ErrorMessages.ExistingTag, tagName));
                }

                context.Tags.Add(new Tag(tagName));

                context.SaveChanges();
            }

            return string.Format(Messages.AddedTag, tagName);
        }
    }
}
