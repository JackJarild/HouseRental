﻿// <auto-generated />
using System;
using HouseRental.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseRental.Api.Migrations
{
    [DbContext(typeof(HouseRentalContext))]
    partial class HouseRentalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseRental.Entities.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BaseDayFee");

                    b.Property<int>("HouseType");

                    b.HasKey("Id");

                    b.ToTable("House");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDayFee = 5.0,
                            HouseType = 2
                        },
                        new
                        {
                            Id = 2,
                            BaseDayFee = 112.3,
                            HouseType = 4
                        },
                        new
                        {
                            Id = 3,
                            BaseDayFee = 33.0,
                            HouseType = 2
                        },
                        new
                        {
                            Id = 4,
                            BaseDayFee = 50.0,
                            HouseType = 4
                        },
                        new
                        {
                            Id = 5,
                            BaseDayFee = 25.5,
                            HouseType = 2
                        });
                });

            modelBuilder.Entity("HouseRental.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<DateTime>("FromDate");

                    b.Property<int>("HouseId");

                    b.Property<int?>("HouseId1");

                    b.Property<double>("Price");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("HouseId1");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("HouseRental.Entities.Reservation", b =>
                {
                    b.HasOne("HouseRental.Entities.House")
                        .WithMany("Reservations")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseRental.Entities.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId1");
                });
#pragma warning restore 612, 618
        }
    }
}
