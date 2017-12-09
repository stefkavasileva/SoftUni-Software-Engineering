using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
    public class SeatingClassConfig : IEntityTypeConfiguration<SeatingClass>
    {
        public void Configure(EntityTypeBuilder<SeatingClass> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasAlternateKey(e => e.Name);

            entity.HasAlternateKey(e => e.Abbreviation);
        }
    }
}
