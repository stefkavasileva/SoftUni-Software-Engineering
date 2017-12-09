using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Instagraph.Data;
using Instagraph.DataProcessor.Models.Dto.Export;
using Newtonsoft.Json;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var post = context
                .Posts
                .Where(p => p.Comments.Count == 0)
                .OrderBy(p => p.Id)
                .Select(p => new PostDto
                {
                    Id = p.Id,
                    Picture = p.Picture.Path,
                    User = p.User.Username
                });

            var result = JsonConvert.SerializeObject(post);
            return result;
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var users = context
                .Users
                .Where(u => u.Posts.Any(p => p.Comments.Any(c => u.Followers.Any(f => f.FollowerId == c.UserId))))
                .Select(u => new UserDto
                {
                    Username = u.Username,
                    Followers = u.Followers.Count
                });

            var result = JsonConvert.SerializeObject(users);

            return result;
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var users = context.Users
                .Select(u => new UserCommentDto
                {
                    Username = u.Username,
                    MostComments = u.Posts.Any() ? u.Posts.Max(p => p.Comments.Count) : 0
                })
                .OrderByDescending(u => u.MostComments)
                .ThenBy(u => u.Username)
                .ToArray();

            var sb = new StringBuilder();
            var serializer = new XmlSerializer(typeof(UserCommentDto[]), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString().Trim();
            return result;
        }
    }
}
