using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
   public class TrainSeatConfig : IEntityTypeConfiguration<TrainSeat>
    {
        public void Configure(EntityTypeBuilder<TrainSeat> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.Train)
                .WithMany(t => t.TrainSeats)
                .HasForeignKey(e => e.TrainId);

            
        }
    }
}
