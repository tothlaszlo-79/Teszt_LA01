using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Teszt_LA01.Models;

namespace Teszt_LA01.Data
{
    public class TesztContext : DbContext
    {
        public TesztContext(DbContextOptions<TesztContext> options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; } // Table for Products
        public DbSet<Category> Categories { get; set; } // Table for Categories

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Teszt 1", Description = "Teszt 1"},
                new Category { CategoryId = 2, Name = "Teszt 2", Description = "Teszt 2" }
              
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Teszt 1", Description = "Teszt 1", Price = 100, IsActive = true, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Teszt 2", Description = "Teszt 2", Price = 200, IsActive = true, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Teszt 3", Description = "Teszt 3", Price = 300, IsActive = true, CategoryId = 2 },
                new Product { ProductId = 4, Name = "Teszt 4", Description = "Teszt 4", Price = 400, IsActive = true, CategoryId = 2 }
                );

        }
    }
}
