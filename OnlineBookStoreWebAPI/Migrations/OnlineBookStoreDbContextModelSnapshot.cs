﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBookStoreWebAPI.Models;

namespace OnlineBookStoreWebAPI.Migrations
{
    [DbContext(typeof(OnlineBookStoreDbContext))]
    partial class OnlineBookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("AuthorCode")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar (50)");

                    b.HasKey("ID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.AuthorProducts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorID");

                    b.Property<int?>("ProductID");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("ProductID");

                    b.ToTable("AuthorProducts");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogDesc")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar (100)");

                    b.Property<int>("CustomerID");

                    b.Property<int>("ViewCount");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryCode")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("CategoryDesc")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar (100)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar (25)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar (25)");

                    b.Property<int>("RoleID");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar (50)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<int>("CustomerID");

                    b.Property<string>("OrderName")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar (255)");

                    b.Property<DateTime>("UpdateAt");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.OrderProducts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderID");

                    b.Property<int?>("ProductID");

                    b.Property<decimal>("Total_Price");

                    b.Property<int>("Total_Qty");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID");

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar (10)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar (255)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar (255)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar (50)");

                    b.Property<string>("PublisherCode")
                        .HasColumnType("nvarchar (100)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar (100)");

                    b.HasKey("ID");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.PublisherProducts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductID");

                    b.Property<int?>("PublisherID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("PublisherID");

                    b.ToTable("PublisherProducts");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar (100)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.AuthorProducts", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Author", "Author")
                        .WithMany("Products")
                        .HasForeignKey("AuthorID");

                    b.HasOne("OnlineBookStoreWebAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Blog", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Customer", "Customer")
                        .WithMany("Blogs")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Employee", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Order", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.OrderProducts", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderID");

                    b.HasOne("OnlineBookStoreWebAPI.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductID");
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.Product", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnlineBookStoreWebAPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnlineBookStoreWebAPI.Models.PublisherProducts", b =>
                {
                    b.HasOne("OnlineBookStoreWebAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID");

                    b.HasOne("OnlineBookStoreWebAPI.Models.Publisher", "Publisher")
                        .WithMany("Products")
                        .HasForeignKey("PublisherID");
                });
#pragma warning restore 612, 618
        }
    }
}