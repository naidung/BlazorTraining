using Microsoft.EntityFrameworkCore;
using ShopOnline.API.Entities;

namespace ShopOnline.API.Data
{
    public class ShopOnlineDBContext:DbContext
    {
        public ShopOnlineDBContext(DbContextOptions<ShopOnlineDBContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 1,
                Name = "Glossier - Beauty Kit",
                Desc = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
                Qty = 100,
                CategoryID = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 2,
                Name = "Curology - Skin Care Kit",
                Desc = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 50,
                Qty = 45,
                CategoryID = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 3,
                Name = "Cocooil - Organic Coconut Oil",
                Desc = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 20,
                Qty = 30,
                CategoryID = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 4,
                Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                Desc = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/Beauty4.png",
                Price = 50,
                Qty = 60,
                CategoryID = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 5,
                Name = "Skin Care Kit",
                Desc = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/Beauty5.png",
                Price = 30,
                Qty = 85,
                CategoryID = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 6,
                Name = "Air Pods",
                Desc = "Air Pods - in-ear wireless headphones",
                ImageURL = "/Images/Electronic/Electronics1.png",
                Price = 100,
                Qty = 120,
                CategoryID = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 7,
                Name = "On-ear Golden Headphones",
                Desc = "On-ear Golden Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronic/Electronics2.png",
                Price = 40,
                Qty = 200,
                CategoryID = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 8,
                Name = "On-ear Black Headphones",
                Desc = "On-ear Black Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronic/Electronics3.png",
                Price = 40,
                Qty = 300,
                CategoryID = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 9,
                Name = "Sennheiser Digital Camera with Tripod",
                Desc = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                ImageURL = "/Images/Electronic/Electronic4.png",
                Price = 600,
                Qty = 20,
                CategoryID = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 10,
                Name = "Canon Digital Camera",
                Desc = "Canon Digital Camera - High quality digital camera provided by Canon",
                ImageURL = "/Images/Electronic/Electronic5.png",
                Price = 500,
                Qty = 15,
                CategoryID = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 11,
                Name = "Nintendo Gameboy",
                Desc = "Gameboy - Provided by Nintendo",
                ImageURL = "/Images/Electronic/technology6.png",
                Price = 100,
                Qty = 60,
                CategoryID = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 12,
                Name = "Black Leather Office Chair",
                Desc = "Very comfortable black leather office chair",
                ImageURL = "/Images/Furniture/Furniture1.png",
                Price = 50,
                Qty = 212,
                CategoryID = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 13,
                Name = "Pink Leather Office Chair",
                Desc = "Very comfortable pink leather office chair",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 50,
                Qty = 112,
                CategoryID = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 14,
                Name = "Lounge Chair",
                Desc = "Very comfortable lounge chair",
                ImageURL = "/Images/Furniture/Furniture3.png",
                Price = 70,
                Qty = 90,
                CategoryID = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 15,
                Name = "Silver Lounge Chair",
                Desc = "Very comfortable Silver lounge chair",
                ImageURL = "/Images/Furniture/Furniture4.png",
                Price = 120,
                Qty = 95,
                CategoryID = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 16,
                Name = "Porcelain Table Lamp",
                Desc = "White and blue Porcelain Table Lamp",
                ImageURL = "/Images/Furniture/Furniture6.png",
                Price = 15,
                Qty = 100,
                CategoryID = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 17,
                Name = "Office Table Lamp",
                Desc = "Office Table Lamp",
                ImageURL = "/Images/Furniture/Furniture7.png",
                Price = 20,
                Qty = 73,
                CategoryID = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 18,
                Name = "Puma Sneakers",
                Desc = "Comfortable Puma Sneakers in most sizes",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 100,
                Qty = 50,
                CategoryID = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 19,
                Name = "Colorful Trainers",
                Desc = "Colorful trainsers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 150,
                Qty = 60,
                CategoryID = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 20,
                Name = "Blue Nike Trainers",
                Desc = "Blue Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes3.png",
                Price = 200,
                Qty = 70,
                CategoryID = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 21,
                Name = "Colorful Hummel Trainers",
                Desc = "Colorful Hummel Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes4.png",
                Price = 120,
                Qty = 120,
                CategoryID = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 22,
                Name = "Red Nike Trainers",
                Desc = "Red Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes5.png",
                Price = 200,
                Qty = 100,
                CategoryID = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 23,
                Name = "Birkenstock Sandles",
                Desc = "Birkenstock Sandles - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes6.png",
                Price = 50,
                Qty = 150,
                CategoryID = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 1,
                UserName = "Bob"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                ID = 2,
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                ID = 1,
                UserID = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                ID = 2,
                UserID = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ID = 1,
                Name = "Beauty",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ID = 2,
                Name = "Furniture",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ID = 3,
                Name = "Electronics",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                ID = 4,
                Name = "Shoes",
                IconCSS = "fas fa-shoe-prints"
            });

        }


        public DbSet<Cart> Carts { get; set;}
        public DbSet<CartItem> CartItems { get; set;}
        public DbSet<Product> Products { get; set;}
        public DbSet<ProductCategory> ProductCategories { get; set;}
        public DbSet<User> Users { get; set;}

    }
}
