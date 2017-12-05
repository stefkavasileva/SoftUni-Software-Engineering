using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Content)
                .HasMaxLength(250);

            entity.HasOne(e => e.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(e => e.Id);
        }
    }
}
