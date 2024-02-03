﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using yuxi_demo.Context;

#nullable disable

namespace yuxi_demo.Context.AppDb
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240203033442_StartUp")]
    partial class StartUp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("yuxi_demo.Entity.Location", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeOnly>("CloseHour")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly>("OpenHour")
                        .HasColumnType("time");

                    b.HasKey("ID");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            ID = new Guid("eeb27d91-eaf8-4632-90ab-6ba82e2b5039"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Bank",
                            OpenHour = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("e951bb42-73e3-473d-9756-5d0597a833ed"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Bakery",
                            OpenHour = new TimeOnly(12, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("9df119e0-0874-4a33-bb25-ed87aa6619fd"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Pharmacy,",
                            OpenHour = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("9efb9793-8591-425d-a19d-173d190877bf"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Park",
                            OpenHour = new TimeOnly(12, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("23c37f80-0285-4f39-b0f7-ad83750e11fa"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Barber shop",
                            OpenHour = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("f81f69c0-8678-4914-95a8-b0d35c4b6199"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Supermarket,",
                            OpenHour = new TimeOnly(12, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("fa2e0e0e-c06f-409f-a0f5-19c5b6b56f8d"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Candy Store",
                            OpenHour = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("c097db03-660a-4168-b2b6-06e086919d46"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Cinema",
                            OpenHour = new TimeOnly(12, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("3de853c9-7cc7-4ef4-a606-4c922c8d7425"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Restaurant",
                            OpenHour = new TimeOnly(13, 0, 0)
                        },
                        new
                        {
                            ID = new Guid("8e35aea7-1fa2-4818-9fb7-35cb4707fd79"),
                            CloseHour = new TimeOnly(10, 0, 0),
                            Description = "Mall",
                            OpenHour = new TimeOnly(12, 0, 0)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}