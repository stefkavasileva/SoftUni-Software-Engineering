using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data.Configurations
{
   public class PostConfig :IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Picture)
                .WithMany(p => p.Posts)
                .HasForeignKey(e => e.Id);       
        }
    }
}
