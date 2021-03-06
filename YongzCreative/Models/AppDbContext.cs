﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Category
            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   CategoryID = 1,
                   CategoryName = "Cap"
               },
               new Category
               {
                   CategoryID = 2,
                   CategoryName = "Hoodie"
               },
               new Category
               {
                   CategoryID = 3,
                   CategoryName = "Sweater"
               },
               new Category
               {
                   CategoryID = 4,
                   CategoryName = "T Shirt"
               },
               new Category
               {
                   CategoryID = 5,
                   CategoryName = "Sweatpants"
               },
               new Category
               {
                   CategoryID = 6,
                   CategoryName = "Leggings"
               });
            #endregion

            #region Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Blue Hoodie",
                    Description = "A hoodie to rock your body.",
                    ImagePath = "/images/hoodies/Hoodie01.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 2,
                    Name = "Orange Hoodie",
                    Description = "",
                    ImagePath = "/images/hoodies/Hoodie02.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 3,
                    Name = "Black Hoodie",
                    Description = "A splashed hoodie that adds taste to your body.",
                    ImagePath = "/images/hoodies/Hoodie03.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 4,
                    Name = "Black Hoodie",
                    Description = "Black and yellow kinda taste.",
                    ImagePath = "/images/hoodies/Hoodie00.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 5,
                    Name = "Black Hoodie",
                    Description = "",
                    ImagePath = "/images/hoodies/Hoodie04.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 6,
                    Name = "Grey and Blue Hoodie",
                    Description = "",
                    ImagePath = "/images/hoodies/Hoodie05.png",
                    Price = 350m,
                    CategoryID = 2,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 7,
                    Name = "YONGZ Cap",
                    Description = "Meroon Cap",
                    ImagePath = "/images/caps/cap04.png",
                    Price = 130m,
                    CategoryID = 1,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 8,
                    Name = "YONGZ Cap",
                    Description = "Black Cap",
                    ImagePath = "/images/caps/cap03.png",
                    Price = 130m,
                    CategoryID = 1,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 9,
                    Name = "YONGZ Cap",
                    Description = "Pitch Cap",
                    ImagePath = "/images/caps/cap02.png",
                    Price = 130m,
                    CategoryID = 1,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 10,
                    Name = "BAD ART CAP",
                    Description = "Green Cap",
                    ImagePath = "/images/caps/cap01.png",
                    Price = 130m,
                    CategoryID = 1,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 11,
                    Name = "BAD ART CAP",
                    Description = "Yellow Cap",
                    ImagePath = "/images/caps/cap05.png",
                    Price = 130m,
                    CategoryID = 1,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 12,
                    Name = "Sky Blue Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater00.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 13,
                    Name = "Black Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater01.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 14,
                    Name = "Orange Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater02.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 15,
                    Name = "Blue Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater03.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 16,
                    Name = "Yellow Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater04.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 17,
                    Name = "3 Coloured Sweater",
                    Description = "",
                    ImagePath = "/images/sweaters/sweater05.png",
                    Price = 350m,
                    CategoryID = 3,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 18,
                    Name = "Black Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings00.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 19,
                    Name = "Grey Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings01.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 20,
                    Name = "Black Leggings",
                    Description = "with white stripes",
                    ImagePath = "/images/leggings/leggings02.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 21,
                    Name = "Black Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings03.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 22,
                    Name = "Pink Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings04.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 23,
                    Name = "Navy Blue Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings05.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 24,
                    Name = "Grey Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings06.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 25,
                    Name = "Dark Blue Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings07.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 26,
                    Name = "Double Grey Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings08.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 27,
                    Name = "Blue and Black Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings09.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 28,
                    Name = "Black Leggings",
                    Description = "",
                    ImagePath = "/images/leggings/leggings10.png",
                    Price = 180m,
                    CategoryID = 6,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 29,
                    Name = "T-Shirts",
                    Description = "A collection of BAD ARD T-Shirts at only R200 each",
                    ImagePath = "/images/tshirts/_0000_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 30,
                    Name = "White Top",
                    Description = "",
                    ImagePath = "/images/tshirts/_0001_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 31,
                    Name = "YONGZ Top",
                    Description = "Black",
                    ImagePath = "/images/tshirts/_0002_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 32,
                    Name = "YONGZ Top",
                    Description = "White",
                    ImagePath = "/images/tshirts/_0003_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 33,
                    Name = "YONGZ Top",
                    Description = "Pitch",
                    ImagePath = "/images/tshirts/_0004_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 34,
                    Name = "White Top",
                    Description = "BAD ART Stickman",
                    ImagePath = "/images/tshirts/_0005_Tshirt.jpg",
                    Price = 200m,
                    CategoryID = 4,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 35,
                    Name = "Grey Sweatpants",
                    Description = "",
                    ImagePath = "/images/sweatpants/Sweatpants00.png",
                    Price = 300m,
                    CategoryID = 5,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 36,
                    Name = "Red Sweatpants",
                    Description = "",
                    ImagePath = "/images/sweatpants/Sweatpants01.png",
                    Price = 300m,
                    CategoryID = 5,
                    status = Status.Available
                }, new Product
                {
                    ProductId = 37,
                    Name = "Yellow Sweatpants",
                    Description = "",
                    ImagePath = "/images/sweatpants/Sweatpants02.png",
                    Price = 300m,
                    CategoryID = 5,
                    status = Status.OutOfStock
                }, new Product
                {
                    ProductId = 38,
                    Name = "Grey Sweatpants",
                    Description = "",
                    ImagePath = "/images/sweatpants/Sweatpants03.png",
                    Price = 300m,
                    CategoryID = 5,
                    status = Status.OutOfStock
                });
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
