using Microsoft.EntityFrameworkCore;
using BackendApp.Models;

namespace BackendApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed some initial data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Description = "A powerful laptop", Price = 999.99m, Quantity = 10 },
                new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 29.99m, Quantity = 50 },
                new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Price = 79.99m, Quantity = 30 }
            );
        }
    }
}
