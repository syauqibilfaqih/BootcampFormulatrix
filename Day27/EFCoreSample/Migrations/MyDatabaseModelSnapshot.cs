﻿// <auto-generated />
using EFCoreSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreSample.Migrations
{
    [DbContext(typeof(MyDatabase))]
    partial class MyDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("EFCoreSample.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronic",
                            Description = "Ini Electronic"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit",
                            Description = "Ini Fruit"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Vegetable",
                            Description = "Ini Vegetable"
                        });
                });

            modelBuilder.Entity("EFCoreSample.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("money")
                        .HasColumnName("ProductPrice");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Cost = 0,
                            ProductName = "TV",
                            QuantityPerUnit = 0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Cost = 0,
                            ProductName = "Radio",
                            QuantityPerUnit = 0
                        });
                });

            modelBuilder.Entity("EFCoreSample.Product", b =>
                {
                    b.HasOne("EFCoreSample.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EFCoreSample.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
