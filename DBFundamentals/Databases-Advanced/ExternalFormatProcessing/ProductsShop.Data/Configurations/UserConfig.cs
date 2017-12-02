using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;

namespace ProductsShop.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Age)
                .IsRequired(false);

            entity.Property(e => e.FirstName)
                .IsRequired(false);

            entity.Property(e => e.LastName)
                .IsRequired(true);
        }
    }
}
