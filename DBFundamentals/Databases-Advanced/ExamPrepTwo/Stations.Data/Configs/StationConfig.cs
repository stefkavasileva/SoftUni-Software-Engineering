using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
    public class StationConfig : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasAlternateKey(e => e.Name);

            entity.HasMany(s => s.TripsTo)
                .WithOne(e => e.DestinationStation)
                .HasForeignKey(t => t.DestinationStationId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(s => s.TripsFrom)
                .WithOne(e => e.OriginStation)
                .HasForeignKey(t => t.OriginStationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
