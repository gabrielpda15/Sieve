﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sieve.API.Models;

namespace Sieve.API.Models.Migrations
{
    [DbContext(typeof(SieveDbContext))]
    [Migration("20191209184613_EmployeeId")]
    partial class EmployeeId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Sieve.API.Models.Location.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(120) CHARACTER SET utf8mb4")
                        .HasMaxLength(120);

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegionId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Sieve.API.Models.Location.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(2) CHARACTER SET utf8mb4")
                        .HasMaxLength(2);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(120) CHARACTER SET utf8mb4")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Sieve.API.Models.Location.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(120) CHARACTER SET utf8mb4")
                        .HasMaxLength(120);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("Sieve.API.Models.Person.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(22) CHARACTER SET utf8mb4")
                        .HasMaxLength(22);

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("CardId")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Sieve.API.Models.Person.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<string>("CTPS")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int?>("IdentityId")
                        .HasColumnType("int");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(22) CHARACTER SET utf8mb4")
                        .HasMaxLength(22);

                    b.Property<double>("Salary")
                        .HasColumnType("double");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("CTPS")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("IdentityId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Sieve.API.Models.Person.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                        .HasMaxLength(18);

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<string>("CompanyName")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("Obs")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(22) CHARACTER SET utf8mb4")
                        .HasMaxLength(22);

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<TimeSpan>("ShippingTime")
                        .HasColumnType("time(6)");

                    b.Property<string>("TrandingName")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CNPJ")
                        .IsUnique();

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.RIdentityRole", b =>
                {
                    b.Property<int>("IdIdentity")
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.HasKey("IdIdentity", "IdRole");

                    b.HasIndex("IdRole");

                    b.ToTable("RIdentityRole");
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.ROrderProduct", b =>
                {
                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdOrder", "IdProduct");

                    b.HasIndex("IdProduct");

                    b.ToTable("ROrderProduct");
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.RSupplierProduct", b =>
                {
                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdSupplier")
                        .HasColumnType("int");

                    b.HasKey("IdProduct", "IdSupplier");

                    b.HasIndex("IdSupplier");

                    b.ToTable("RSupplierProduct");
                });

            modelBuilder.Entity("Sieve.API.Models.Sales.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<string>("CardHolder")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("varchar(19) CHARACTER SET utf8mb4")
                        .HasMaxLength(19);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<double>("Limit")
                        .HasColumnType("double");

                    b.Property<DateTime>("Payday")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ShelfLife")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CardNumber")
                        .IsUnique();

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Sieve.API.Models.Sales.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("MinQnt")
                        .HasColumnType("int");

                    b.Property<bool>("MustHaveCard")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Percentage")
                        .HasColumnType("double");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShelfLife")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("Sieve.API.Models.Sales.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<double>("Shipment")
                        .HasColumnType("double");

                    b.Property<string>("ShippingData")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Sieve.API.Models.Security.Identity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Identity");
                });

            modelBuilder.Entity("Sieve.API.Models.Security.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.CategorySection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("CategorySection");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CategorySection");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SectionId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AvgPrice")
                        .HasColumnType("double");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("double");

                    b.Property<int>("TotalQnt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.StorageEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Batch")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreationUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("EditionDate")
                        .IsConcurrencyToken()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EditionUser")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShelfLife")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("StorageId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("StorageEntry");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Category", b =>
                {
                    b.HasBaseType("Sieve.API.Models.Storage.CategorySection");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasIndex("SectionId");

                    b.ToTable("CategorySection");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Section", b =>
                {
                    b.HasBaseType("Sieve.API.Models.Storage.CategorySection");

                    b.ToTable("CategorySection");

                    b.HasDiscriminator().HasValue("Section");
                });

            modelBuilder.Entity("Sieve.API.Models.Location.City", b =>
                {
                    b.HasOne("Sieve.API.Models.Location.Country", null)
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Sieve.API.Models.Location.Region", null)
                        .WithMany("Cities")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Location.Region", b =>
                {
                    b.HasOne("Sieve.API.Models.Location.Country", null)
                        .WithMany("Regions")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Person.Client", b =>
                {
                    b.HasOne("Sieve.API.Models.Sales.Card", "Card")
                        .WithOne()
                        .HasForeignKey("Sieve.API.Models.Person.Client", "CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Person.Employee", b =>
                {
                    b.HasOne("Sieve.API.Models.Security.Identity", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.RIdentityRole", b =>
                {
                    b.HasOne("Sieve.API.Models.Security.Identity", "Identity")
                        .WithMany("Roles")
                        .HasForeignKey("IdIdentity")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Sieve.API.Models.Security.Role", "Role")
                        .WithMany()
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.ROrderProduct", b =>
                {
                    b.HasOne("Sieve.API.Models.Sales.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("IdOrder")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Sieve.API.Models.Storage.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Relations.RSupplierProduct", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Sieve.API.Models.Person.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("IdSupplier")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Sales.Discount", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Sales.Order", b =>
                {
                    b.HasOne("Sieve.API.Models.Person.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Product", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sieve.API.Models.Storage.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Storage", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.StorageEntry", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Storage", "Storage")
                        .WithMany()
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sieve.API.Models.Storage.Category", b =>
                {
                    b.HasOne("Sieve.API.Models.Storage.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
