using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Models.Dto.Import
{
    [XmlType("comment")]
    public class CommentDto
    {
        [Required]
        [MaxLength(250)]
        [XmlElement("content")]
        public string Content { get; set; }

        [Required]
        [XmlElement("user")]
        public string User { get; set; }

        [Required]
        [XmlElement("post")]
        public PostCommentDto Post { get; set; }
    }
}
