using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Instagraph.Data;
using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Newtonsoft.Json;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var posts = context
                .Posts
                .Include(p => p.Picture)
                .Include(p => p.User)
                .Where(p => p.Comments.Count == 0)
                .OrderBy(p => p.Id)
                .Select(e => new
                {
                    Id = e.Id,
                    Picture = e.Picture.Path,
                    User = e.User.Username
                })
                .ToList();

            var jsonString = JsonConvert.SerializeObject(posts);

            return jsonString;
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var users = context
                .Users
                .OrderBy(u => u.Id)
                .Include(u => u.Posts)
                .Include(u => u.Comments)
                .Include(u => u.Followers)
                .Include(u => u.UsersFollowing)
                .Where(u => u.Posts.Any(p => p.Comments.Any(c => u.Followers.Any(uc => uc.Follower.Username.Equals(c.User.Username)))))
                .Select(e => new
                {
                    Username = e.Username,
                    Followers = e.Followers.Count
                }).ToArray();

            return JsonConvert.SerializeObject(users);
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var users = context
                .Users
                .Include(u => u.Posts)
                .ThenInclude(p => p.Comments)
                .ToArray();

            var usersResult = new List<UserAndPostDto>();

            foreach (var user in users)
            {
                var mostCommentPost = user.Posts.OrderByDescending(p => p.Comments.Count).FirstOrDefault();
                var userDto = new UserAndPostDto();
                var mostCommentsCount = 0;

                if (mostCommentPost != null)
                {
                    mostCommentsCount = mostCommentPost.Comments.Count;
                }

                userDto.Username = user.Username;
                userDto.MostComments = mostCommentsCount;

                usersResult.Add(userDto);

            }

            usersResult = usersResult.OrderByDescending(u => u.MostComments).ThenBy(u => u.Username).ToList();

            var document = new XDocument();
            document.Add(new XElement("users"));

            foreach (var user in usersResult)
            {
                document.Root.Add(new XElement("user", new XElement("Username", user.Username), new XElement("MostComments", user.MostComments)));
            }

            return document.ToString();
        }
    }
}
