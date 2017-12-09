using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Stations.Models.Enums;

namespace Stations.Models
{
    public class Train
    {
        public Train()
        {
            this.TrainSeats = new HashSet<TrainSeat>();
            this.Trips = new HashSet<Trip>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string TrainNumber { get; set; }

        public TrainType? Type { get; set; }

        public ICollection<TrainSeat> TrainSeats { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
