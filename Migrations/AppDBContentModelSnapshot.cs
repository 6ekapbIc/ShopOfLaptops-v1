﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("description");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shop.Data.Models.Laptop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("available");

                    b.Property<bool>("backlight");

                    b.Property<bool>("camera");

                    b.Property<int>("categoryId");

                    b.Property<double>("diagonal");

                    b.Property<int>("frequencyOfDisplay");

                    b.Property<double>("frequencyOfProcessor");

                    b.Property<string>("img");

                    b.Property<string>("modelOfProcessor");

                    b.Property<string>("modelOfVideoCard");

                    b.Property<string>("name");

                    b.Property<string>("os");

                    b.Property<long>("price");

                    b.Property<int>("ram");

                    b.Property<string>("shortDescription");

                    b.Property<int>("slotsOfRam");

                    b.Property<string>("typeOfDisplay");

                    b.Property<string>("typeOfMemory");

                    b.Property<string>("volumeOfMemory");

                    b.Property<string>("volumeOfVideoCard");

                    b.Property<double>("weight");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Laptop");
                });

            modelBuilder.Entity("Shop.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("orderTime");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("surName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("laptopId");

                    b.Property<int>("orderId");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("laptopId");

                    b.HasIndex("orderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int?>("laptopid");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("laptopid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Shop.Data.Models.Laptop", b =>
                {
                    b.HasOne("Shop.Data.Models.Category", "Category")
                        .WithMany("laptops")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("Shop.Data.Models.Laptop", "laptop")
                        .WithMany()
                        .HasForeignKey("laptopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Shop.Data.Models.Laptop", "laptop")
                        .WithMany()
                        .HasForeignKey("laptopid");
                });
#pragma warning restore 612, 618
        }
    }
}
