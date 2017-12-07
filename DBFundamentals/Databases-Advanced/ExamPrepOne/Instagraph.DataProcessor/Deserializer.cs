using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Newtonsoft.Json;
using Instagraph.Data;
using Instagraph.DataProcessor.Constants;
using Instagraph.Models;
using Models.Dto;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var pictures = JsonConvert.DeserializeObject<Picture[]>(jsonString);

            foreach (var picture in pictures)
            {

                if (string.IsNullOrWhiteSpace(picture.Path) ||
                    context.Pictures.Any(p => p.Path.Equals(picture.Path)) ||
                    picture.Size <= 0)
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                context.Pictures.Add(picture);
                context.SaveChanges();

                sb.AppendLine(string.Format(SuccessMessage.Picture, picture.Path));

            }

            return sb.ToString().Trim();
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var userPicsDto = JsonConvert.DeserializeObject<UserPicDto[]>(jsonString);
            var validUsers = new List<User>();

            foreach (var userPicDto in userPicsDto)
            {
                if (!IsValid(userPicDto))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                if (validUsers.Any(u => u.Username == userPicDto.Username))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var pic = context.Pictures.SingleOrDefault(p => p.Path == userPicDto.ProfilePicture);

                if (pic is null)
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var user = new User
                {
                    Username = userPicDto.Username,
                    Password = userPicDto.Password,
                    ProfilePicture = pic,
                };

                validUsers.Add(user);
                sb.AppendLine(string.Format(SuccessMessage.User, user.Username));
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var usersJson = JsonConvert.DeserializeObject<FollowerUserDto[]>(jsonString);

            var usersToDb = new List<UserFollower>();

            foreach (var userDto in usersJson)
            {
                if (!context.Users.Any(u => u.Username.Equals(userDto.User)) ||
                    !context.Users.Any(u => u.Username.Equals(userDto.Follower))||
                    !IsValid(userDto))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                if (usersToDb.Any(uf =>
                    uf.User.Username == userDto.User && uf.Follower.Username.Equals(userDto.Follower)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var userAndFollower = new UserFollower
                {
                    User = context.Users.Single(u => u.Username.Equals(userDto.User)),
                    Follower = context.Users.Single(u => u.Username.Equals(userDto.Follower))
                };

                usersToDb.Add(userAndFollower);
                sb.AppendLine(string.Format(SuccessMessage.UserFollower, userDto.Follower, userDto.User));

            }

            context.UsersFollowers.AddRange(usersToDb);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var posts = new List<Post>();

            var documnet = XDocument.Parse(xmlString);
            var elements = documnet.Root.Elements();

            foreach (var xElement in elements)
            {
                var caption = xElement.Element("caption")?.Value;
                var username = xElement.Element("user")?.Value;
                var picturePath = xElement.Element("picture")?.Value;

                var picture = context.Pictures.SingleOrDefault(p => p.Path.Equals(picturePath));
                var user = context.Users.SingleOrDefault(u => u.Username.Equals(username));

                if (picture == null || user == null || string.IsNullOrWhiteSpace(caption))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var post = new Post()
                {
                    Caption = caption,
                    User = user,
                    Picture = picture
                };

                posts.Add(post);
                sb.AppendLine(string.Format(SuccessMessage.Post, post.Caption));
            }

            context.Posts.AddRange(posts);
            context.SaveChanges();
            return sb.ToString();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
           var sb = new StringBuilder();

            var elements = XDocument.Parse(xmlString).Root.Elements();
            var comments = new List<Comment>();

            foreach (var xElement in elements)
            {
                var content = xElement.Element("content")?.Value;
                var username = xElement.Element("user")?.Value;
                var  postIdAsString = xElement.Element("post")?.Attribute("id")?.Value;

                if (string.IsNullOrWhiteSpace(content) || string.IsNullOrWhiteSpace(username) || postIdAsString == null)
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var postId = int.Parse(postIdAsString);
                var post = context.Posts.SingleOrDefault(p => p.Id == postId);
                var user = context.Users.SingleOrDefault(u => u.Username.Equals(username));

                if (post == null || user == null)
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var comment = new Comment
                {
                    Content = content,
                    Post = post,
                    User = user
                };

                comments.Add(comment);
                sb.AppendLine(string.Format(SuccessMessage.Comment, content));
            }

            context.Comments.AddRange(comments);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);

            return isValid;
        }

    }
}
