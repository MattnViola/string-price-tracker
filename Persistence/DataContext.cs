
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Price> Prices { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=string-price-tracker;Username=postgres;Password=test");

    }
}