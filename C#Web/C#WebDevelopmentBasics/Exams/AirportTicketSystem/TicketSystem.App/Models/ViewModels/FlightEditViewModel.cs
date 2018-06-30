using System;

namespace TicketSystem.App.Models.ViewModels
{
    public class FlightEditViewModel
    {
        public int Id { get; set; }

        public string Destination { get; set; }

        public string Origin { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string ImageUrl { get; set; }
    }
}
