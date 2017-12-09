using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
   public class TrainConfig : IEntityTypeConfiguration<Train>
    {
        public void Configure(EntityTypeBuilder<Train> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasAlternateKey(e => e.TrainNumber);

        }
    }
}
