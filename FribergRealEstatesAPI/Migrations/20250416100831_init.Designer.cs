﻿// <auto-generated />
using System;
using FribergRealEstatesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FribergRealEstatesAPI.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20250416100831_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommunId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommunId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<int>("RealtorId")
                        .HasColumnType("int");

                    b.Property<int>("ResidenceId")
                        .HasColumnType("int");

                    b.Property<bool>("Sold")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RealtorId");

                    b.HasIndex("ResidenceId")
                        .IsUnique();

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Commun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Communs");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Realtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.ToTable("Realtors");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Residence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int?>("BiArea")
                        .HasColumnType("int");

                    b.Property<int>("BuildYear")
                        .HasColumnType("int");

                    b.Property<int?>("CommunId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Facilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloorRows")
                        .HasColumnType("int");

                    b.Property<int?>("Floors")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("ImageUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<double?>("MonthlyFee")
                        .HasColumnType("float");

                    b.Property<double>("OperatingCost")
                        .HasColumnType("float");

                    b.Property<int?>("ParkingSlotNumber")
                        .HasColumnType("int");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("CommunId");

                    b.ToTable("Residences");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Address", b =>
                {
                    b.HasOne("FribergRealEstatesAPI.Models.Commun", "Commun")
                        .WithMany("Addresses")
                        .HasForeignKey("CommunId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Commun");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Advert", b =>
                {
                    b.HasOne("FribergRealEstatesAPI.Models.Realtor", "Realtor")
                        .WithMany("ActiveAdverts")
                        .HasForeignKey("RealtorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FribergRealEstatesAPI.Models.Residence", "Residence")
                        .WithOne("Advert")
                        .HasForeignKey("FribergRealEstatesAPI.Models.Advert", "ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Realtor");

                    b.Navigation("Residence");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Agency", b =>
                {
                    b.HasOne("FribergRealEstatesAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Realtor", b =>
                {
                    b.HasOne("FribergRealEstatesAPI.Models.Agency", "Agency")
                        .WithMany("Realtors")
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Residence", b =>
                {
                    b.HasOne("FribergRealEstatesAPI.Models.Address", "Address")
                        .WithOne("Residence")
                        .HasForeignKey("FribergRealEstatesAPI.Models.Residence", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FribergRealEstatesAPI.Models.Commun", null)
                        .WithMany("Residences")
                        .HasForeignKey("CommunId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Address", b =>
                {
                    b.Navigation("Residence");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Agency", b =>
                {
                    b.Navigation("Realtors");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Commun", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Residences");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Realtor", b =>
                {
                    b.Navigation("ActiveAdverts");
                });

            modelBuilder.Entity("FribergRealEstatesAPI.Models.Residence", b =>
                {
                    b.Navigation("Advert");
                });
#pragma warning restore 612, 618
        }
    }
}
