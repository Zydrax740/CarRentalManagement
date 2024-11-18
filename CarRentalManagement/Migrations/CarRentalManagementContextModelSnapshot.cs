﻿// <auto-generated />
using System;
using CarRentalManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalManagement.Migrations
{
    [DbContext(typeof(CarRentalManagementContext))]
    partial class CarRentalManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarRentalManagement.Domain.Booking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("CarRentalManagement.Domain.Colour", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Colour");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9863),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9875),
                            Name = "Black",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9877),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 213, DateTimeKind.Local).AddTicks(9878),
                            Name = "Blue",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Domain.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrivingLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CarRentalManagement.Domain.Make", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Make");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(120),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(121),
                            Name = "BMW",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(123),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(123),
                            Name = "Toyota",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Domain.Model", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Model");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(33),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(34),
                            Name = "i4",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            id = 2,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(59),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(59),
                            Name = "X5",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            id = 3,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(60),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(61),
                            Name = "Prius",
                            UpdatedBy = "System"
                        },
                        new
                        {
                            id = 4,
                            CreatedBy = "System",
                            DateCreated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(62),
                            DateUpdated = new DateTime(2024, 11, 18, 17, 10, 18, 214, DateTimeKind.Local).AddTicks(62),
                            Name = "C-HR",
                            UpdatedBy = "System"
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Domain.Vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicensePlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
