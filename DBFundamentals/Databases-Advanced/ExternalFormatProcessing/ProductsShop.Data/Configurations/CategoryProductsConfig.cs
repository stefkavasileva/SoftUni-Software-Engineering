using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;
namespace ProductsShop.Data.Configurations
{
   public class CategoryProductsConfig :IEntityTypeConfiguration<CategoryProducts>
    {
        public void Configure(EntityTypeBuilder<CategoryProducts> entity)
        {
            entity.HasKey(e => new {e.ProductId, e.CategoryId});

            entity.HasOne(e => e.Product)
                .WithMany(p => p.CategoryProductses)
                .HasForeignKey(e=> e.ProductId);

            entity.HasOne(e => e.Category)
                .WithMany(c => c.CategoryProductses)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
