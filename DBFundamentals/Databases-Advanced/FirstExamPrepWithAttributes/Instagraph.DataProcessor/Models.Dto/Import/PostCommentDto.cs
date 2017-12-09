using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Models.Dto.Import
{
    [XmlType("post")]
    public class PostCommentDto
    {
        [Required]
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}