using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Models.Dto.Export
{
    [XmlType("user")]
    public class UserCommentDto
    {
        public string Username { get; set; }

        public int MostComments { get; set; }
    }
}
