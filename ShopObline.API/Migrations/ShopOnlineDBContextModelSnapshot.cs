﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.API.Data;

#nullable disable

namespace ShopOnline.API.Migrations
{
    [DbContext(typeof(ShopOnlineDBContext))]
    partial class ShopOnlineDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopOnline.API.Entities.Cart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.API.Entities.CartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.API.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Desc = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Glossier - Beauty Kit",
                            Price = 100m,
                            Qty = 100
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Desc = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Curology - Skin Care Kit",
                            Price = 50m,
                            Qty = 45
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 1,
                            Desc = "A kit provided by Curology, containing skin care products",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Organic Coconut Oil",
                            Price = 20m,
                            Qty = 30
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 1,
                            Desc = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                            Price = 50m,
                            Qty = 60
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 1,
                            Desc = "Skin Care Kit, containing skin care and hair care products",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Skin Care Kit",
                            Price = 30m,
                            Qty = 85
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 3,
                            Desc = "Air Pods - in-ear wireless headphones",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            Price = 100m,
                            Qty = 120
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            Desc = "On-ear Golden Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "On-ear Golden Headphones",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            Desc = "On-ear Black Headphones - these headphones are not wireless",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "On-ear Black Headphones",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 3,
                            Desc = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Digital Camera with Tripod",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 3,
                            Desc = "Canon Digital Camera - High quality digital camera provided by Canon",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Canon Digital Camera",
                            Price = 500m,
                            Qty = 15
                        },
                        new
                        {
                            ID = 11,
                            CategoryID = 3,
                            Desc = "Gameboy - Provided by Nintendo",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Qty = 60
                        },
                        new
                        {
                            ID = 12,
                            CategoryID = 2,
                            Desc = "Very comfortable black leather office chair",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Black Leather Office Chair",
                            Price = 50m,
                            Qty = 212
                        },
                        new
                        {
                            ID = 13,
                            CategoryID = 2,
                            Desc = "Very comfortable pink leather office chair",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pink Leather Office Chair",
                            Price = 50m,
                            Qty = 112
                        },
                        new
                        {
                            ID = 14,
                            CategoryID = 2,
                            Desc = "Very comfortable lounge chair",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Lounge Chair",
                            Price = 70m,
                            Qty = 90
                        },
                        new
                        {
                            ID = 15,
                            CategoryID = 2,
                            Desc = "Very comfortable Silver lounge chair",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Qty = 95
                        },
                        new
                        {
                            ID = 16,
                            CategoryID = 2,
                            Desc = "White and blue Porcelain Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Porcelain Table Lamp",
                            Price = 15m,
                            Qty = 100
                        },
                        new
                        {
                            ID = 17,
                            CategoryID = 2,
                            Desc = "Office Table Lamp",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Qty = 73
                        },
                        new
                        {
                            ID = 18,
                            CategoryID = 4,
                            Desc = "Comfortable Puma Sneakers in most sizes",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Puma Sneakers",
                            Price = 100m,
                            Qty = 50
                        },
                        new
                        {
                            ID = 19,
                            CategoryID = 4,
                            Desc = "Colorful trainsers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Colorful Trainers",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            ID = 20,
                            CategoryID = 4,
                            Desc = "Blue Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Blue Nike Trainers",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            ID = 21,
                            CategoryID = 4,
                            Desc = "Colorful Hummel Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Colorful Hummel Trainers",
                            Price = 120m,
                            Qty = 120
                        },
                        new
                        {
                            ID = 22,
                            CategoryID = 4,
                            Desc = "Red Nike Trainers - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Red Nike Trainers",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            ID = 23,
                            CategoryID = 4,
                            Desc = "Birkenstock Sandles - available in most sizes",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Birkenstock Sandles",
                            Price = 50m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.API.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("IconCSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Beauty"
                        },
                        new
                        {
                            ID = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Furniture"
                        },
                        new
                        {
                            ID = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Electronics"
                        },
                        new
                        {
                            ID = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Shoes"
                        });
                });

            modelBuilder.Entity("ShopOnline.API.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            ID = 2,
                            UserName = "Sarah"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
