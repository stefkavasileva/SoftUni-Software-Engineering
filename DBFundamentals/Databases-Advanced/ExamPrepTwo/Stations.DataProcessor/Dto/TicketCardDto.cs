using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Stations.DataProcessor.Dto
{
    [XmlType("Card")]
    public class TicketCardDto
    {
        [XmlAttribute]
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
    }
}
