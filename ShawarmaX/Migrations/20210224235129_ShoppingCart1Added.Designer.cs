﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShawarmaX.Models;

namespace ShawarmaX.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210224235129_ShoppingCart1Added")]
    partial class ShoppingCart1Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShawarmaX.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Meals"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Desserts"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drinks and snacks"
                        });
                });

            modelBuilder.Entity("ShawarmaX.Models.Shawarma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOffer")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Shawarmas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/172.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Chicken shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.",
                            Name = "Shawarma Chicken",
                            Price = 1.95m,
                            ShortDescription = "Turkish Chicken Shawarma Sandwich!"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/174.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Meat shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.",
                            Name = "Turkish meat Shawarma Sandwich!",
                            Price = 1.95m,
                            ShortDescription = "You'll love it!"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/130249.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Chicken and meat shawarma with 3 favorite sauce with taco bread and potato and pickles.",
                            Name = "Shawarma Box",
                            Price = 5.95m,
                            ShortDescription = "Turkish Chicken and meat Shawarma Sandwich!"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/148.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Chicken and meat shawarma with potato and sauce pickles and lettuce.",
                            Name = "Shawarma Dubble X",
                            Price = 2.95m,
                            ShortDescription = "Turkish Chicken and meat Shawarma Sandwich!"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/130013.jpg",
                            InStock = true,
                            IsOffer = true,
                            LongDescription = ".3 Turkish Chicken OR meat Shawarma Sandwich! with potato and Pepsi with sauce and pickles.",
                            Name = "Shawarma Chicken Offers",
                            Price = 5.95m,
                            ShortDescription = " Turkish Chicken OR meat Shawarma Sandwich!"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/130145.jpg",
                            InStock = true,
                            IsOffer = true,
                            LongDescription = ".30 pics Turkish Chicken OR meat Shawarma ! with 6 favorite sauce .",
                            Name = "Shawarma Mega Offers",
                            Price = 7.95m,
                            ShortDescription = " Turkish Chicken OR meat Shawarma Mega Box!"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/130016.jpg",
                            InStock = true,
                            IsOffer = true,
                            LongDescription = ".Turkish Chicken OR meat Shawarma Box! with potato and Pepsi with sauce and pickles.",
                            Name = "Shawarma Box Offers",
                            Price = 4.95m,
                            ShortDescription = " Turkish Chicken OR meat Shawarma !"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            ImageUrl = "https://scontent-arn2-1.xx.fbcdn.net/v/t1.0-9/13179290_614365935380238_346645495429938451_n.jpg?_nc_cat=111&ccb=3&_nc_sid=9267fe&_nc_ohc=B2VTtdiDM7oAX-OMK8v&_nc_oc=AQnCscYlcIg74Vw_9QBncQ6aAjzYVuMAjYciFamnSPPp1aX98LFIBSxt9ZJhe19wZ-o&_nc_ht=scontent-arn2-1.xx&oh=12343366a3fc5465c65bf3ace7a58a99&oe=60553F9E",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Dough contains goat cheese and pistachios and topped with syrup.",
                            Name = "kunafeh",
                            Price = 1.50m,
                            ShortDescription = " Turkish Desserts !"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/40075-2.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ".Dough  pistachios and topped with syrup.",
                            Name = "Basbousah",
                            Price = 1.50m,
                            ShortDescription = " Arabic Desserts !"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/40075-2.jpg",
                            InStock = true,
                            IsOffer = true,
                            LongDescription = ".Dough  pistachios and topped with syrup.",
                            Name = "Basbousah",
                            Price = 1.00m,
                            ShortDescription = " Arabic Desserts !"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/40032-2.jpg",
                            InStock = true,
                            IsOffer = true,
                            LongDescription = ".A box contains 15 pieces of chocolate cookies stuffed with brownie particles.",
                            Name = "cookies",
                            Price = 1.50m,
                            ShortDescription = " cookies chocklate !"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/76.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". Pepsi klass 400ml.",
                            Name = "Pepsi",
                            Price = 0.50m,
                            ShortDescription = " Pepsi klass 400ml !"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/80.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". 7up klass 400ml.",
                            Name = "7up",
                            Price = 0.50m,
                            ShortDescription = " 7up klass 400ml !"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/84.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". Mirinda klass 400ml.",
                            Name = "Mirinda",
                            Price = 0.50m,
                            ShortDescription = " Mirinda klass 400ml !"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/90265.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". Pepsi Diet klass 400ml.",
                            Name = "Pepsi Diet",
                            Price = 0.50m,
                            ShortDescription = " Pepsi klass 400ml !"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/80025-2.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". any sauce : cheese , mayounez , katchap , hot , trkish sauce , halpenus and shawrma sauce.",
                            Name = "sauce box",
                            Price = 0.50m,
                            ShortDescription = " sauce 30ml !"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/177.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". potato box 300ml with any sauce.",
                            Name = "potato box",
                            Price = 0.80m,
                            ShortDescription = " potato box 300ml !"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            ImageUrl = "https://www.shawarmer.com/assets/api/products/80019-2.jpg",
                            InStock = true,
                            IsOffer = false,
                            LongDescription = ". Pickled and jalapeno box 100ml .",
                            Name = "Pickled and jalapeno box",
                            Price = 0.80m,
                            ShortDescription = " Pickled and jalapeno 100ml !"
                        });
                });

            modelBuilder.Entity("ShawarmaX.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ShawarmaId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ShawarmaId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ShawarmaX.Models.Shawarma", b =>
                {
                    b.HasOne("ShawarmaX.Models.Category", "Category")
                        .WithMany("Shawarmas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShawarmaX.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ShawarmaX.Models.Shawarma", "Shawarma")
                        .WithMany()
                        .HasForeignKey("ShawarmaId");

                    b.Navigation("Shawarma");
                });

            modelBuilder.Entity("ShawarmaX.Models.Category", b =>
                {
                    b.Navigation("Shawarmas");
                });
#pragma warning restore 612, 618
        }
    }
}
