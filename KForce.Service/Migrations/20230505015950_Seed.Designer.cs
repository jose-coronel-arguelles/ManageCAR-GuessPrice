﻿// <auto-generated />
using KForce.Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KForce.Service.Migrations
{
    [DbContext(typeof(KForceDbContext))]
    [Migration("20230505015950_Seed")]
    partial class Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KForce.Service.Model.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Doors")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Red",
                            Doors = 2,
                            Make = "Audi",
                            Model = "R8",
                            Price = 79995m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            Color = "Black",
                            Doors = 4,
                            Make = "Tesla",
                            Model = "3",
                            Price = 54995m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 3,
                            Color = "White",
                            Doors = 2,
                            Make = "Porshe",
                            Model = "911 991",
                            Price = 155000m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 4,
                            Color = "Blue",
                            Doors = 5,
                            Make = "Mercedes-Benz",
                            Model = "GLE 63S",
                            Price = 83995m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 5,
                            Color = "Silver",
                            Doors = 5,
                            Make = "BMW",
                            Model = "X6 M",
                            Price = 62995m,
                            Year = 2020
                        });
                });
#pragma warning restore 612, 618
        }
    }
}