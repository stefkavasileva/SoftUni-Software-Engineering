using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Stations.Models.Enums;

namespace Stations.Models
{
    public class CustomerCard
    {
        public CustomerCard()
        {
            this.BoughtTickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength]
        public string Name { get; set; }

        public int Age { get; set; }

        public CardType Type { get; set; }

        public ICollection<Ticket> BoughtTickets { get; set; }
    }
}
