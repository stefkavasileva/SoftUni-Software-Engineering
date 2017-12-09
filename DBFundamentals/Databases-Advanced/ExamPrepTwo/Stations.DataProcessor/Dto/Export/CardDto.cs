using System.Xml.Serialization;

namespace Stations.DataProcessor.Dto.Export
{
    [XmlType("Card")]
    public class CardDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        public TicketDto[] Tickets { get; set; } = new TicketDto[0];
    }
}