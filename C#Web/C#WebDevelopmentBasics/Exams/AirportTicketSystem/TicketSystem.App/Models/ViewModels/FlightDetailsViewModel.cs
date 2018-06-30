using System;
using System.Collections.Generic;
using TicketSystem.Models;

namespace TicketSystem.App.Models.ViewModels
{
    public class FlightDetailsViewModel
    {
        public FlightDetailsViewModel()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }

        public string Diration { get; set; }

        public string Origin { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Ticket> Tickets { get; set; }    
    }
}
