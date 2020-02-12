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

        protected override void OnModelCreating(ModelBuilder modelBuilder)        {            modelBuilder.Entity<Product>().HasData(                new Product                {                    ProductId = 1,                    Name = "YONGZ Cap",                    Description = "Black cap with a taste of red.",                    ImagePath = "~/images/Cap01.png",                    Price = 130m                }, new Product                {                    ProductId = 2,                    Name = "YONGZ Cap",                    Description = "Peach cap styled with maroon.",                    ImagePath = "~/images/Cap02.png",                    Price = 130                }, new Product                {                    ProductId = 3,                    Name = "YONGZ Cap",                    Description = "Black cap lightened up with white.",                    ImagePath = "~/images/Cap03.png",                    Price = 130                }, new Product                {                    ProductId = 4,                    Name = "YONGZ Cap",                    Description = "Maroon cap styled with white.",                    ImagePath = "~/images/Cap04.png",                    Price = 130                });            base.OnModelCreating(modelBuilder);        }
    }
}