﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(databaseContext))]
    partial class databaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("WebApplication5.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("imageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
