using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GildedRoseBoutique.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base (options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 1, Name = "Item1", Description = "Item 1 Description", Price = 20.00M, ImageUrl = "\\Images\\item1.jpeg", Quantity = 0 });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 2, Name = "Item2", Description = "Item 2 Description", Price = 45.00M, ImageUrl = "\\Images\\item2.jpeg", Quantity = 5 });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 3, Name = "Item3", Description = "Item 3 Description", Price = 40.50M, ImageUrl = "\\Images\\item3.jpeg", Quantity = 8 });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 4, Name = "Item4", Description = "Item 4 Description", Price = 35.00M, ImageUrl = "\\Images\\item4.jpeg", Quantity = 10 });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 5, Name = "Item5", Description = "Item 5 Description", Price = 80.00M, ImageUrl = "\\Images\\item5.jpeg", Quantity = 15 });
            modelBuilder.Entity<Item>().HasData(new Item { ItemId = 6, Name = "Item6", Description = "Item 6 Description", Price = 75.95M, ImageUrl = "\\Images\\item6.jpeg", Quantity = 2 });
        }
        
    }
}


