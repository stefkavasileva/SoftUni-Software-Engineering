using Instagraph.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Instagraph.Data.Configurations
{
  public  class UserConfig :IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.Id);

            entity.HasAlternateKey(e => e.Username);

            entity.Property(e => e.Username)
                .HasMaxLength(30);

            entity.Property(e => e.Password)
                .HasMaxLength(20);

            entity.HasOne(e => e.ProfilePicture)
                .WithMany(p => p.Users)
                .HasForeignKey(e => e.Id);

            entity.HasMany(e => e.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(e => e.Id);
        }
    }
}
