﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YongzCreative.Models;

namespace YongzCreative.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200518220634_AddOrderDbSet")]
    partial class AddOrderDbSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YongzCreative.Models.CartLine", b =>
                {
                    b.Property<int>("CartLineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderID");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("CartLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("YongzCreative.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2");

                    b.Property<string>("Line3");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<bool>("Shipped");

                    b.Property<string>("Zip");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("YongzCreative.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("category");

                    b.Property<int>("status");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "A hoodie to rock your body.",
                            ImagePath = "/images/hoodies/Hoodie01.png",
                            Name = "Blue Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 0
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "",
                            ImagePath = "/images/hoodies/Hoodie02.png",
                            Name = "Orange Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 1
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "A splashed hoodie that adds taste to your body.",
                            ImagePath = "/images/hoodies/Hoodie03.png",
                            Name = "Black Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 0
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Black and yellow kinda taste.",
                            ImagePath = "/images/hoodies/Hoodie00.png",
                            Name = "Black Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 1
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "",
                            ImagePath = "/images/hoodies/Hoodie04.png",
                            Name = "Black Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 0
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "",
                            ImagePath = "/images/hoodies/Hoodie05.png",
                            Name = "Grey and Blue Hoodie",
                            Price = 350m,
                            category = 1,
                            status = 1
                        },
                        new
                        {
                            ProductId = 7,
                            Description = "Meroon Cap",
                            ImagePath = "/images/caps/cap04.png",
                            Name = "YONGZ Cap",
                            Price = 130m,
                            category = 0,
                            status = 0
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "Black Cap",
                            ImagePath = "/images/caps/cap03.png",
                            Name = "YONGZ Cap",
                            Price = 130m,
                            category = 0,
                            status = 0
                        },
                        new
                        {
                            ProductId = 9,
                            Description = "Pitch Cap",
                            ImagePath = "/images/caps/cap02.png",
                            Name = "YONGZ Cap",
                            Price = 130m,
                            category = 0,
                            status = 0
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "Green Cap",
                            ImagePath = "/images/caps/cap01.png",
                            Name = "BAD ART CAP",
                            Price = 130m,
                            category = 0,
                            status = 1
                        },
                        new
                        {
                            ProductId = 11,
                            Description = "Yellow Cap",
                            ImagePath = "/images/caps/cap05.png",
                            Name = "BAD ART CAP",
                            Price = 130m,
                            category = 0,
                            status = 1
                        },
                        new
                        {
                            ProductId = 12,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater00.png",
                            Name = "Sky Blue Sweater",
                            Price = 350m,
                            category = 2,
                            status = 1
                        },
                        new
                        {
                            ProductId = 13,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater01.png",
                            Name = "Black Sweater",
                            Price = 350m,
                            category = 2,
                            status = 0
                        },
                        new
                        {
                            ProductId = 14,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater02.png",
                            Name = "Orange Sweater",
                            Price = 350m,
                            category = 2,
                            status = 0
                        },
                        new
                        {
                            ProductId = 15,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater03.png",
                            Name = "Blue Sweater",
                            Price = 350m,
                            category = 2,
                            status = 1
                        },
                        new
                        {
                            ProductId = 16,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater04.png",
                            Name = "Yellow Sweater",
                            Price = 350m,
                            category = 2,
                            status = 1
                        },
                        new
                        {
                            ProductId = 17,
                            Description = "",
                            ImagePath = "/images/sweaters/sweater05.png",
                            Name = "3 Coloured Sweater",
                            Price = 350m,
                            category = 2,
                            status = 1
                        },
                        new
                        {
                            ProductId = 18,
                            Description = "",
                            ImagePath = "/images/leggings/leggings00.png",
                            Name = "Black Leggings",
                            Price = 180m,
                            category = 5,
                            status = 0
                        },
                        new
                        {
                            ProductId = 19,
                            Description = "",
                            ImagePath = "/images/leggings/leggings01.png",
                            Name = "Grey Leggings",
                            Price = 180m,
                            category = 5,
                            status = 0
                        },
                        new
                        {
                            ProductId = 20,
                            Description = "with white stripes",
                            ImagePath = "/images/leggings/leggings02.png",
                            Name = "Black Leggings",
                            Price = 180m,
                            category = 5,
                            status = 0
                        },
                        new
                        {
                            ProductId = 21,
                            Description = "",
                            ImagePath = "/images/leggings/leggings03.png",
                            Name = "Black Leggings",
                            Price = 180m,
                            category = 5,
                            status = 0
                        },
                        new
                        {
                            ProductId = 22,
                            Description = "",
                            ImagePath = "/images/leggings/leggings04.png",
                            Name = "Pink Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 23,
                            Description = "",
                            ImagePath = "/images/leggings/leggings05.png",
                            Name = "Navy Blue Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 24,
                            Description = "",
                            ImagePath = "/images/leggings/leggings06.png",
                            Name = "Grey Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 25,
                            Description = "",
                            ImagePath = "/images/leggings/leggings07.png",
                            Name = "Dark Blue Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 26,
                            Description = "",
                            ImagePath = "/images/leggings/leggings08.png",
                            Name = "Double Grey Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 27,
                            Description = "",
                            ImagePath = "/images/leggings/leggings09.png",
                            Name = "Blue and Black Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 28,
                            Description = "",
                            ImagePath = "/images/leggings/leggings10.png",
                            Name = "Black Leggings",
                            Price = 180m,
                            category = 5,
                            status = 1
                        },
                        new
                        {
                            ProductId = 29,
                            Description = "A collection of BAD ARD T-Shirts at only R200 each",
                            ImagePath = "/images/tshirts/_0000_Tshirt.jpg",
                            Name = "T-Shirts",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 30,
                            Description = "",
                            ImagePath = "/images/tshirts/_0001_Tshirt.jpg",
                            Name = "White Top",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 31,
                            Description = "Black",
                            ImagePath = "/images/tshirts/_0002_Tshirt.jpg",
                            Name = "YONGZ Top",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 32,
                            Description = "White",
                            ImagePath = "/images/tshirts/_0003_Tshirt.jpg",
                            Name = "YONGZ Top",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 33,
                            Description = "Pitch",
                            ImagePath = "/images/tshirts/_0004_Tshirt.jpg",
                            Name = "YONGZ Top",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 34,
                            Description = "BAD ART Stickman",
                            ImagePath = "/images/tshirts/_0005_Tshirt.jpg",
                            Name = "White Top",
                            Price = 200m,
                            category = 3,
                            status = 0
                        },
                        new
                        {
                            ProductId = 35,
                            Description = "",
                            ImagePath = "/images/sweatpants/Sweatpants00.png",
                            Name = "Grey Sweatpants",
                            Price = 300m,
                            category = 4,
                            status = 1
                        },
                        new
                        {
                            ProductId = 36,
                            Description = "",
                            ImagePath = "/images/sweatpants/Sweatpants01.png",
                            Name = "Red Sweatpants",
                            Price = 300m,
                            category = 4,
                            status = 0
                        },
                        new
                        {
                            ProductId = 37,
                            Description = "",
                            ImagePath = "/images/sweatpants/Sweatpants02.png",
                            Name = "Yellow Sweatpants",
                            Price = 300m,
                            category = 4,
                            status = 1
                        },
                        new
                        {
                            ProductId = 38,
                            Description = "",
                            ImagePath = "/images/sweatpants/Sweatpants03.png",
                            Name = "Grey Sweatpants",
                            Price = 300m,
                            category = 4,
                            status = 1
                        });
                });

            modelBuilder.Entity("YongzCreative.Models.CartLine", b =>
                {
                    b.HasOne("YongzCreative.Models.Order")
                        .WithMany("Lines")
                        .HasForeignKey("OrderID");

                    b.HasOne("YongzCreative.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}