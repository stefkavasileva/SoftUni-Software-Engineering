using HTTPServer.ByTheCakeApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace HTTPServer.ByTheCakeApplication.Data
{
    public class ByTheCakeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Orders)
                .WithOne(o => o.Product)
                .HasForeignKey(p => p.OrderId);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasKey(po => new { po.OrderId, po.ProductId });


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = @"Server=DESKTOP-P3EEUC7\SQLEXPRESS;Database=ByTheCakeDb;Integrated Security=True;";
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
