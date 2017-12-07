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

            entity.HasOne(e => e.ProfilePicture)
                .WithMany(p => p.Users)
                .HasForeignKey(e => e.ProfilePictureId);
        }
    }
}
