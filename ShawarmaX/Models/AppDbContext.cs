using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShawarmaX.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shawarma> Shawarmas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Meals" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Desserts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Drinks and snacks" });

            //seed pies

            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 1,
                Name = "Shawarma Chicken",
                Price = 1.95M,
                ShortDescription = "Turkish Chicken Shawarma Sandwich!",
                LongDescription =
                    ".Chicken shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/172.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 2,
                Name = "Turkish meat Shawarma Sandwich!",
                Price = 1.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                   ".Meat shawarma with your choice of favorite sauce with fresh Turkish bread and pickles.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/174.jpg",
                InStock = true,
                IsOffer = false,


            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 3,
                Name = "Shawarma Box",
                Price = 5.95M,
                ShortDescription = "Turkish Chicken and meat Shawarma Sandwich!",
                LongDescription =
                    ".Chicken and meat shawarma with 3 favorite sauce with taco bread and potato and pickles.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/130249.jpg",
                InStock = true,
                IsOffer = false,

            });

            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 4,
                Name = "Shawarma Dubble X",
                Price = 2.95M,
                ShortDescription = "Turkish Chicken and meat Shawarma Sandwich!",
                LongDescription =
                   ".Chicken and meat shawarma with potato and sauce pickles and lettuce.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/148.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 5,
                Name = "Shawarma Chicken Offers",
                Price = 5.95M,
                ShortDescription = " Turkish Chicken OR meat Shawarma Sandwich!",
                LongDescription =
                   ".3 Turkish Chicken OR meat Shawarma Sandwich! with potato and Pepsi with sauce and pickles.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/130013.jpg",
                InStock = true,
                IsOffer = true,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 6,
                Name = "Shawarma Mega Offers",
                Price = 7.95M,
                ShortDescription = " Turkish Chicken OR meat Shawarma Mega Box!",
                LongDescription =
                  ".30 pics Turkish Chicken OR meat Shawarma ! with 6 favorite sauce .",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/130145.jpg",
                InStock = true,
                IsOffer = true,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 7,
                Name = "Shawarma Box Offers",
                Price = 4.95M,
                ShortDescription = " Turkish Chicken OR meat Shawarma !",
                LongDescription =
                  ".Turkish Chicken OR meat Shawarma Box! with potato and Pepsi with sauce and pickles.",
                CategoryId = 1,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/130016.jpg",
                InStock = true,
                IsOffer = true,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 8,
                Name = "kunafeh",
                Price = 1.50M,
                ShortDescription = " Turkish Desserts !",
                LongDescription =
                  ".Dough contains goat cheese and pistachios and topped with syrup.",
                CategoryId = 2,
                ImageUrl = "https://scontent-arn2-1.xx.fbcdn.net/v/t1.0-9/13179290_614365935380238_346645495429938451_n.jpg?_nc_cat=111&ccb=3&_nc_sid=9267fe&_nc_ohc=B2VTtdiDM7oAX-OMK8v&_nc_oc=AQnCscYlcIg74Vw_9QBncQ6aAjzYVuMAjYciFamnSPPp1aX98LFIBSxt9ZJhe19wZ-o&_nc_ht=scontent-arn2-1.xx&oh=12343366a3fc5465c65bf3ace7a58a99&oe=60553F9E",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 9,
                Name = "Basbousah",
                Price = 1.50M,
                ShortDescription = " Arabic Desserts !",
                LongDescription =
                  ".Dough  pistachios and topped with syrup.",
                CategoryId = 2,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/40075-2.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 10,
                Name = "Basbousah",
                Price = 1.00M,
                ShortDescription = " Arabic Desserts !",
                LongDescription =
                  ".Dough  pistachios and topped with syrup.",
                CategoryId = 2,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/40075-2.jpg",
                InStock = true,
                IsOffer = true,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 11,
                Name = "cookies",
                Price = 1.50M,
                ShortDescription = " cookies chocklate !",
                LongDescription =
                  ".A box contains 15 pieces of chocolate cookies stuffed with brownie particles.",
                CategoryId = 2,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/40032-2.jpg",
                InStock = true,
                IsOffer = true,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 12,
                Name = "Pepsi",
                Price = 0.50M,
                ShortDescription = " Pepsi klass 400ml !",
                LongDescription =
                 ". Pepsi klass 400ml.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/76.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 13,
                Name = "7up",
                Price = 0.50M,
                ShortDescription = " 7up klass 400ml !",
                LongDescription =
                 ". 7up klass 400ml.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/80.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 14,
                Name = "Mirinda",
                Price = 0.50M,
                ShortDescription = " Mirinda klass 400ml !",
                LongDescription =
                ". Mirinda klass 400ml.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/84.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 15,
                Name = "Pepsi Diet",
                Price = 0.50M,
                ShortDescription = " Pepsi klass 400ml !",
                LongDescription =
               ". Pepsi Diet klass 400ml.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/90265.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 16,
                Name = "sauce box",
                Price = 0.50M,
                ShortDescription = " sauce 30ml !",
                LongDescription =
               ". any sauce : cheese , mayounez , katchap , hot , trkish sauce , halpenus and shawrma sauce.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/80025-2.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 17,
                Name = "potato box",
                Price = 0.80M,
                ShortDescription = " potato box 300ml !",
                LongDescription =
               ". potato box 300ml with any sauce.",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/177.jpg",
                InStock = true,
                IsOffer = false,

            });
            modelBuilder.Entity<Shawarma>().HasData(new Shawarma
            {
                Id = 18,
                Name = "Pickled and jalapeno box",
                Price = 0.80M,
                ShortDescription = " Pickled and jalapeno 100ml !",
                LongDescription =
               ". Pickled and jalapeno box 100ml .",
                CategoryId = 3,
                ImageUrl = "https://www.shawarmer.com/assets/api/products/80019-2.jpg",
                InStock = true,
                IsOffer = false,

            });
        }




    }
}
