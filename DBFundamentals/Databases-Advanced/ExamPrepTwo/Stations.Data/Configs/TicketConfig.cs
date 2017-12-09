using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stations.Models;

namespace Stations.Data.Configs
{
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.CustomerCard)
                .WithMany(cc => cc.BoughtTickets)
                .HasForeignKey(e => e.CustomerCardId);

       
        }
    }
}
