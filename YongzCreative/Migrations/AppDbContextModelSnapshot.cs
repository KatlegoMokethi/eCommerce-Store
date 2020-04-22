﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YongzCreative.Models;

namespace YongzCreative.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YongzCreative.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImagePath");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "A hoodie to rock your body.",
                            ImagePath = "/images/hoodies/Hoodie01.png",
                            Name = "Hoodie",
                            Price = 300m
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "A hoodie to rock your body.",
                            ImagePath = "/images/hoodies/Hoodie02.png",
                            Name = "Hoodie",
                            Price = 300m
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "A hoodie to rock your body.",
                            ImagePath = "/images/hoodies/Hoodie03.png",
                            Name = "Hoodie",
                            Price = 300m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
