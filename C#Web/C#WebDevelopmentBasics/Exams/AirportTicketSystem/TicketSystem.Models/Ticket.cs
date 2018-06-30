using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Class { get; set; }

        public int CustumerId { get; set; }

        public User Custumer { get; set; }

        [Required]
        public int FlightId { get; set; }

        public Flight Flight { get; set; }
    }
}
