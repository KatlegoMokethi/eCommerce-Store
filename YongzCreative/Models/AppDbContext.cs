using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)        {            modelBuilder.Entity<Product>().HasData(                new Product                {                    ProductId = 1,                    Name = "Hoodie",                    Description = "A hoodie to rock your body.",                    ImagePath = "/images/hoodies/Hoodie01.png",                    Price = 300m                }, new Product                {                    ProductId = 2,                    Name = "Hoodie",                    Description = "A hoodie to rock your body.",                    ImagePath = "/images/hoodies/Hoodie02.png",                    Price = 300m                }, new Product                {                    ProductId = 3,                    Name = "Hoodie",                    Description = "A splashed hoodie that adds taste to your body.",                    ImagePath = "/images/hoodies/Hoodie03.png",                    Price = 300m                });            base.OnModelCreating(modelBuilder);        }
    }
}