
namespace KittenApp.Data
{
    using KittenApp.Models;
    using Microsoft.EntityFrameworkCore;

    public class KittenAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Kitten> Kittens { get; set; }

        public DbSet<Breed> Breeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Data Source=.;Database=KittenApp;Integrated Security=True";
                optionsBuilder.UseSqlServer(connectionString);

            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
