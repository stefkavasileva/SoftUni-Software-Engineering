using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
    public class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> entity)
        {
            entity.HasKey(e => e.Id);

            //entity.HasOne(e => e.DestinationStation)
            //    .WithMany(dc => dc.TripsTo)
            //    .HasForeignKey(e => e.DestinationStationId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //entity.HasOne(e => e.OriginStation)
            //    .WithMany(e => e.TripsFrom)
            //    .HasForeignKey(e => e.OriginStationId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
