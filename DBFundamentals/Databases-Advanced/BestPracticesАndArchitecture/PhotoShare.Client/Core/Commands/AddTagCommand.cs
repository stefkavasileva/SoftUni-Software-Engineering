namespace PhotoShare.Client.Core.Commands
{
    using Models;
    using Data;
    using Utilities;
    using Contracts;
    using System;
    using System.Linq;

    public class AddTagCommand : ICommand
    {
        // AddTag <tag>
        public string Execute(string[] data)
        {
            var tagName = data[1].ValidateOrTransform();

            using (var context = new PhotoShareContext())
            {
                if (context.Tags.Any(t => t.Name == tagName))
                {
                    throw new ArgumentException($"Tag {tagName} exists!");
                }

                context.Tags.Add(new Tag(tagName));

                context.SaveChanges();
            }

            return $"Tag {tagName} was added successfully to database!";
        }
    }
}
