﻿// <auto-generated />
using System;
using DistantPointTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DistantPointTest.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211014210140_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DistantPointTest.Entities.Courier", b =>
                {
                    b.Property<int>("CourierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaxDimensions")
                        .HasColumnType("float");

                    b.Property<double>("MaxWeight")
                        .HasColumnType("float");

                    b.Property<double>("MinDimensions")
                        .HasColumnType("float");

                    b.Property<double>("MinWeight")
                        .HasColumnType("float");

                    b.Property<int>("OrdersMade")
                        .HasColumnType("int");

                    b.Property<int>("PricerId")
                        .HasColumnType("int");

                    b.HasKey("CourierId");

                    b.ToTable("Courier");
                });

            modelBuilder.Entity("DistantPointTest.Entities.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<int>("CourierId")
                        .HasColumnType("int");

                    b.Property<string>("CourierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Depth")
                        .HasColumnType("float");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<int?>("PricePerCourierId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.Property<double>("cubicCM")
                        .HasColumnType("float");

                    b.HasKey("PackageId");

                    b.HasIndex("PricePerCourierId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("DistantPointTest.Entities.PricePerCourier", b =>
                {
                    b.Property<int>("PricePerCourierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AdditionalPrice")
                        .HasColumnType("float");

                    b.Property<int>("CourierId")
                        .HasColumnType("int");

                    b.Property<string>("CourierName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ExtraWeight")
                        .HasColumnType("float");

                    b.Property<double>("ExtraWeightPrice")
                        .HasColumnType("float");

                    b.Property<double>("MaxDimensions1")
                        .HasColumnType("float");

                    b.Property<double>("MaxDimensions2")
                        .HasColumnType("float");

                    b.Property<double>("MaxDimensions3")
                        .HasColumnType("float");

                    b.Property<double>("MaxDimensions4")
                        .HasColumnType("float");

                    b.Property<double>("MaxWeight1")
                        .HasColumnType("float");

                    b.Property<double>("MaxWeight2")
                        .HasColumnType("float");

                    b.Property<double>("MaxWeight3")
                        .HasColumnType("float");

                    b.Property<double>("MaxWeight4")
                        .HasColumnType("float");

                    b.Property<double>("MinDimensions1")
                        .HasColumnType("float");

                    b.Property<double>("MinDimensions2")
                        .HasColumnType("float");

                    b.Property<double>("MinDimensions3")
                        .HasColumnType("float");

                    b.Property<double>("MinDimensions4")
                        .HasColumnType("float");

                    b.Property<double>("MinWeight1")
                        .HasColumnType("float");

                    b.Property<double>("MinWeight2")
                        .HasColumnType("float");

                    b.Property<double>("MinWeight3")
                        .HasColumnType("float");

                    b.Property<double>("MinWeight4")
                        .HasColumnType("float");

                    b.Property<double>("PriceDimension1")
                        .HasColumnType("float");

                    b.Property<double>("PriceDimension2")
                        .HasColumnType("float");

                    b.Property<double>("PriceDimension3")
                        .HasColumnType("float");

                    b.Property<double>("PriceDimension4")
                        .HasColumnType("float");

                    b.Property<double>("PriceWeight1")
                        .HasColumnType("float");

                    b.Property<double>("PriceWeight2")
                        .HasColumnType("float");

                    b.Property<double>("PriceWeight3")
                        .HasColumnType("float");

                    b.Property<double>("PriceWeight4")
                        .HasColumnType("float");

                    b.HasKey("PricePerCourierId");

                    b.ToTable("PricePerCourier");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                            ConcurrencyStamp = "05d9e49c-02bd-4bee-b5ef-7d0c3639a6d3",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int?>("PackageId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PackageId");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8554266 -b401-4519-9aeb-a9283053fc58",
                            Email = "ballerscoutmk@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "BALLERSCOUTMK@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKHMweZ7Z0YgbPSInPDawD6f/NculsNyhvyc8Ho9fL7hlqjCOYUZhlruMF7JZxy4BA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                            RoleId = "b4280b6a-0613-4cbd-a9e6-f1701e926e73"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DistantPointTest.Entities.Package", b =>
                {
                    b.HasOne("DistantPointTest.Entities.PricePerCourier", null)
                        .WithMany("Package")
                        .HasForeignKey("PricePerCourierId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.HasOne("DistantPointTest.Entities.Package", null)
                        .WithMany("IdentityUser")
                        .HasForeignKey("PackageId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
