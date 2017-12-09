using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.DataProcessor.Constatnts;
using Instagraph.DataProcessor.Models.Dto.Import;
using Instagraph.Models;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var pictureDtos = JsonConvert.DeserializeObject<PictureDto[]>(jsonString);
            var validPictures = new List<Picture>();

            foreach (var pictureDto in pictureDtos)
            {
                if (!IsValid(pictureDto) || validPictures.Any(p => p.Path.Equals(pictureDto.Path)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var picture = Mapper.Map<Picture>(pictureDto);
                validPictures.Add(picture);

                sb.AppendLine(string.Format(SuccessMessage.Picture, picture.Path));
            }

            context.Pictures.AddRange(validPictures);
            context.SaveChanges();

            var result = sb.ToString().Trim();
            return result;
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var userDtos = JsonConvert.DeserializeObject<UserDto[]>(jsonString);
            var validUsers = new List<User>();

            foreach (var userDto in userDtos)
            {
                if (!IsValid(userDto) || !context.Pictures.Any(p => p.Path.Equals(userDto.ProfilePicture)) || validUsers.Any(u => u.Username.Equals(userDto.Username)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var picture = context.Pictures.FirstOrDefault(p => p.Path.Equals(userDto.ProfilePicture));

                var validUser = new User(userDto.Username,userDto.Password,picture);
                validUsers.Add(validUser);

                sb.AppendLine(string.Format(SuccessMessage.User, validUser.Username));
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            var result = sb.ToString().Trim();
            return result;
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var userFollowerDtos = JsonConvert.DeserializeObject<UserFollowerDto[]>(jsonString);
            var validUserFollowers = new List<UserFollower>();

            foreach (var userFollowerDto in userFollowerDtos)
            {
                if (!IsValid(userFollowerDto) || !context.Users.Any(u=>u.Username.Equals(userFollowerDto.User)) || !context.Users.Any(u => u.Username.Equals(userFollowerDto.Follower)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                if (validUserFollowers.Any(u =>
                    u.User.Username.Equals(userFollowerDto.User) &&
                    u.Follower.Username.Equals(userFollowerDto.Follower)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var user = context.Users.FirstOrDefault(u => u.Username.Equals(userFollowerDto.User));
                var follower = context.Users.FirstOrDefault(u => u.Username.Equals(userFollowerDto.Follower));

                var userFollower = new UserFollower(user,follower);
                validUserFollowers.Add(userFollower);

                sb.AppendLine(
                    string.Format(SuccessMessage.UserFollower, userFollowerDto.Follower, userFollowerDto.User));
            }

            context.UsersFollowers.AddRange(validUserFollowers);
            context.SaveChanges();

            var result = sb.ToString().Trim();
            return result;
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(typeof(PostDto[]), new XmlRootAttribute("posts"));
            var elements = (PostDto[])serializer.Deserialize(new StringReader(xmlString));

            var validPosts = new List<Post>();

            foreach (var element in elements)
            {
                if (!IsValid(element) || !context.Users.Any(u=>u.Username.Equals(element.User)) || !context.Pictures.Any(p=>p.Path.Equals(element.Picture)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var user = context.Users.FirstOrDefault(u => u.Username.Equals(element.User));
                var pic = context.Pictures.FirstOrDefault(p=>p.Path.Equals(element.Picture));

                var post = new Post(element.Caption,user,pic);
                validPosts.Add(post);

                sb.AppendLine(string.Format(SuccessMessage.Post, post.Caption));
            }

            context.Posts.AddRange(validPosts);
            context.SaveChanges();

            var result = sb.ToString().Trim();
            return result;
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var sb = new StringBuilder();
            var serializer = new XmlSerializer(typeof(CommentDto[]),new XmlRootAttribute("comments"));
            var elements = (CommentDto[]) serializer.Deserialize(new StringReader(xmlString));

            var validComments  = new List<Comment>();

            foreach (var commentDto in elements)
            {
                if (!IsValid(commentDto) || !context.Users.Any(u => u.Username.Equals(commentDto.User)) ||
                    !context.Posts.Any(p => p.Id.Equals(commentDto.Post.Id)))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                var user = context.Users.FirstOrDefault(u => u.Username.Equals(commentDto.User));
                var post = context.Posts.FirstOrDefault(p => p.Id.Equals(commentDto.Post.Id));

                var comment = new Comment(commentDto.Content,user,post);
                validComments.Add(comment);
                sb.AppendLine(string.Format(SuccessMessage.Comment, comment.Content));
            }

            context.Comments.AddRange(validComments);
            context.SaveChanges();

            var result = sb.ToString().Trim();
            return result;
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
