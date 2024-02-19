﻿// <auto-generated />
using System;
using InsuranceApp.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsuranceApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240218111322_AddedImageUrls")]
    partial class AddedImageUrls
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsuranceApp.Models.Insurance", b =>
                {
                    b.Property<Guid>("InsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InsuranceId");

                    b.ToTable("Insurances");

                    b.HasData(
                        new
                        {
                            InsuranceId = new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"),
                            Name = "Life Insurance"
                        },
                        new
                        {
                            InsuranceId = new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"),
                            Name = "Health Insurance"
                        },
                        new
                        {
                            InsuranceId = new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"),
                            Name = "Car Insurance"
                        },
                        new
                        {
                            InsuranceId = new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"),
                            Name = "Home Insurance"
                        },
                        new
                        {
                            InsuranceId = new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"),
                            Name = "Travel Insurance"
                        });
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceProduct", b =>
                {
                    b.Property<Guid>("InsuranceProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("InsuranceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InsuranceProductId");

                    b.HasIndex("InsuranceId");

                    b.ToTable("InsuranceProducts");

                    b.HasData(
                        new
                        {
                            InsuranceProductId = new Guid("a1b2c3d4-e5f6-7890-a1b2-c3d4e5f67890"),
                            Description = "Basic coverage for life insurance.",
                            Discount = 10m,
                            ImageUrl = "https://images.pexels.com/photos/35160/pexels-photo.jpg?auto=compress&cs=tinysrgb&w=600",
                            InsuranceId = new Guid("b66b6b38-12c9-4483-83a6-15974a926ba7"),
                            Name = "Life Insurance - Basic",
                            Price = 1000m
                        },
                        new
                        {
                            InsuranceProductId = new Guid("b1c2d3e4-f5a6-7890-b1c2-d3e4f5a67890"),
                            Description = "Premium coverage for health insurance.",
                            Discount = 15m,
                            ImageUrl = "https://images.pexels.com/photos/1346347/pexels-photo-1346347.jpeg?auto=compress&cs=tinysrgb&w=600",
                            InsuranceId = new Guid("5b954223-15e1-4ae6-9d19-2881f6e5016b"),
                            Name = "Health Insurance - Premium",
                            Price = 2000m
                        },
                        new
                        {
                            InsuranceProductId = new Guid("c1d2e3f4-a5b6-7890-c1d2-e3f4a5b67890"),
                            Description = "Full coverage for car insurance.",
                            Discount = 20m,
                            ImageUrl = "https://images.pexels.com/photos/2262628/pexels-photo-2262628.jpeg?auto=compress&cs=tinysrgb&w=600",
                            InsuranceId = new Guid("6cbb9cc8-e8ca-4c8d-8230-347b95dcd151"),
                            Name = "Car Insurance - Full Coverage",
                            Price = 1500m
                        },
                        new
                        {
                            InsuranceProductId = new Guid("d1e2f3a4-b5c6-7890-d1e2-f3a4b5c67890"),
                            Description = "Comprehensive coverage for home insurance.",
                            Discount = 10m,
                            ImageUrl = "https://images.pexels.com/photos/9646747/pexels-photo-9646747.jpeg?auto=compress&cs=tinysrgb&w=600",
                            InsuranceId = new Guid("4428b5ac-b650-4f21-aa21-2d94197e8b78"),
                            Name = "Home Insurance - Comprehensive",
                            Price = 1200m
                        },
                        new
                        {
                            InsuranceProductId = new Guid("e1f2a3b4-c5d6-7890-e1f2-a3b4c5d67890"),
                            Description = "Global coverage for travel insurance.",
                            Discount = 15m,
                            ImageUrl = "https://images.pexels.com/photos/1076240/pexels-photo-1076240.jpeg?auto=compress&cs=tinysrgb&w=600",
                            InsuranceId = new Guid("7104de08-0b1c-4808-b6f2-9a740fdab608"),
                            Name = "Travel Insurance - Global",
                            Price = 800m
                        });
                });

            modelBuilder.Entity("InsuranceApp.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("InsuranceProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("PurchaseDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("InsuranceProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceCustomer", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("InsuranceCustomer");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceProduct", b =>
                {
                    b.HasOne("InsuranceApp.Models.Insurance", "Insurance")
                        .WithMany("InsuranceProducts")
                        .HasForeignKey("InsuranceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insurance");
                });

            modelBuilder.Entity("InsuranceApp.Models.Product", b =>
                {
                    b.HasOne("InsuranceApp.Models.InsuranceCustomer", "Customer")
                        .WithMany("Products")
                        .HasForeignKey("CustomerId1");

                    b.HasOne("InsuranceApp.Models.InsuranceProduct", "InsuranceProduct")
                        .WithMany("Products")
                        .HasForeignKey("InsuranceProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("InsuranceProduct");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("InsuranceApp.Models.Insurance", b =>
                {
                    b.Navigation("InsuranceProducts");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InsuranceApp.Models.InsuranceCustomer", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
