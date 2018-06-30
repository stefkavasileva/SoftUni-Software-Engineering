using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSystem.Models
{
    public class Flight
    {
        public Flight()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Destination { get; set; }

        [Required]
        public string Origin { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public string ImageUrl { get; set; }

        public bool IsPublic { get; set; }

        public ICollection<Ticket> Tickets { get; set; }    
    }
}
