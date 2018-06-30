using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSystem.App.Models.BindingModels
{
    public class FlightAddBindingModel
    {
        [Required(ErrorMessage = "Destination is required")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Origin is required")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required")]
        public TimeSpan Time { get; set; }

        public string ImageUrl { get; set; }
    }
}
