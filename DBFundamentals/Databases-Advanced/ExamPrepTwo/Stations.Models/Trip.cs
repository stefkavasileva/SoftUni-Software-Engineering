using System;
using System.ComponentModel.DataAnnotations;
using Stations.Models.Enums;

namespace Stations.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public int OriginStationId { get; set; }

        [Required]
        public Station OriginStation { get; set; }

        [Required]
        public int DestinationStationId { get; set; }

        [Required]
        public Station DestinationStation { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public int TrainId { get; set; }

        [Required]
        public Train Train { get; set; }

        public TripStatus Status { get; set; } = TripStatus.OnTime;

        public TimeSpan? TimeDifference { get; set; }
    }
}
