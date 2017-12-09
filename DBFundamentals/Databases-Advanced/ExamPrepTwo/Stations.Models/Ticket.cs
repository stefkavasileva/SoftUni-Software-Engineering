using System.ComponentModel.DataAnnotations;

namespace Stations.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Price { get; set; }

        [Required]
        public string SeatingPlace { get; set; }

        [Required]
        public int TripId { get; set; }

        [Required]
        public Trip Trip { get; set; }

        public int? CustomerCardId { get; set; }

        public CustomerCard CustomerCard { get; set; }
    }
}
