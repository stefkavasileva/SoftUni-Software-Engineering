using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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
            var validPics = new List<Picture>();

            foreach (var picture in pictures)
            {
                if (!IsPicValid(context, picture))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

                validPics.Add(picture);
                sb.AppendLine(string.Format(SuccessMessage.Picture, picture.Path));
            }

            context.Pictures.AddRange(validPics);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var userPicsDto = JsonConvert.DeserializeObject<User[]>(jsonString);
            var users = new List<User>();

            foreach (var userPicDto in userPicsDto)
            {
                if (string.IsNullOrWhiteSpace(userPicDto.ProfilePicture.Path) ||
                    string.IsNullOrWhiteSpace(userPicDto.Username) ||
                    string.IsNullOrWhiteSpace(userPicDto.Password) ||
                context.Users.Any(u => u.Username.Equals(userPicDto.Username) ||
                !context.Pictures.Any(p => p.Path.Equals(userPicDto.ProfilePicture.Path))))
                {
                    sb.AppendLine(ErrorMessage.InvalidData);
                    continue;
                }

              //  var user = Mapper.Map<User>(userPicDto);
                //user.ProfilePicture = context.Pictures.Single(p => p.Path.Equals(userPicDto.ProfilePicture));
                users.Add(userPicDto);

                sb.AppendLine(SuccessMessage.User);
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            throw new NotImplementedException();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            throw new NotImplementedException();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            throw new NotImplementedException();
        }




        private static bool IsPicValid(InstagraphContext context, Picture picture)
        {
            return context.Pictures.Any(p => p.Path.Equals(picture.Path))
                || string.IsNullOrWhiteSpace(picture.Path) ||
                   picture.Size < 0;
        }
    }
}
