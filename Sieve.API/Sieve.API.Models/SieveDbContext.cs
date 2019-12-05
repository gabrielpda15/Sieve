using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sieve.API.Models
{
    public class SieveDbContext : DbContext
    {
        public SieveDbContext(DbContextOptions<SieveDbContext> options) : base(options) { }

        public DbSet<Storage.Category> Categories { get; set; }
        public DbSet<Storage.Section> Sections { get; set; }
        public DbSet<Storage.Product> Products { get; set; }
        public DbSet<Storage.Storage> Storages { get; set; }
        public DbSet<Storage.StorageEntry> StorageEntries { get; set; }

        public DbSet<Security.Identity> Identities { get; set; }
        public DbSet<Security.Role> Roles { get; set; }

        public DbSet<Sales.Card> Cards { get; set; }
        public DbSet<Sales.Discount> Discounts { get; set; }
        public DbSet<Sales.Order> Orders { get; set; }

        public DbSet<Person.Client> Clients { get; set; }
        public DbSet<Person.Employee> Employees { get; set; }
        public DbSet<Person.Supplier> Suppliers { get; set; }

        /// LOCATIONS
        public DbSet<Location.City> Cities { get; set; }
        public DbSet<Location.Country> Countries { get; set; }
        public DbSet<Location.Region> Regions { get; set; }

        /// RELATIONS 
        public DbSet<Relations.RIdentityRole> RIdentityRoles { get; set; }
        public DbSet<Relations.ROrderProduct> ROrderProducts { get; set; }
        public DbSet<Relations.RSupplierProduct> RSupplierProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Storage.Category>().HasBaseType<Storage.CategorySection>();
            builder.Entity<Storage.Category>().HasOne(x => x.Section).WithMany();
            builder.Entity<Storage.Section>().HasBaseType<Storage.CategorySection>();
            builder.Entity<Storage.Product>().HasOne(x => x.Category).WithMany();
            builder.Entity<Storage.Product>().HasOne(x => x.Section).WithMany();
            builder.Entity<Storage.Storage>().HasOne(x => x.Product).WithMany();
            builder.Entity<Storage.StorageEntry>().HasOne(x => x.Storage).WithMany();
            builder.Entity<Security.Identity>().HasIndex(x => x.Username).IsUnique();
            builder.Entity<Security.Identity>().HasIndex(x => x.Email).IsUnique();
            builder.Entity<Security.Role>().HasIndex(x => x.Description).IsUnique();
            builder.Entity<Sales.Card>().HasIndex(x => x.CardNumber).IsUnique();
            builder.Entity<Sales.Discount>().HasOne(x => x.Product).WithMany();
            builder.Entity<Sales.Order>().HasOne(x => x.Client).WithMany();
            builder.Entity<Person.Client>().HasOne(x => x.Card).WithOne().HasForeignKey<Person.Client>(x => x.CardId);
            builder.Entity<Person.Client>().HasIndex(x => x.CPF).IsUnique();
            builder.Entity<Person.Client>().HasIndex(x => x.Email).IsUnique();
            builder.Entity<Person.Employee>().HasIndex(x => x.CTPS).IsUnique();
            builder.Entity<Person.Employee>().HasIndex(x => x.CPF).IsUnique();
            builder.Entity<Person.Employee>().HasIndex(x => x.Email).IsUnique();
            builder.Entity<Person.Supplier>().HasIndex(x => x.CNPJ).IsUnique();
            builder.Entity<Person.Supplier>().HasIndex(x => x.CPF).IsUnique();
            builder.Entity<Person.Supplier>().HasIndex(x => x.Email).IsUnique();

            /// LOCATIONS
            builder.Entity<Location.Country>().HasMany(x => x.Regions).WithOne().HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Location.Region>().HasMany(x => x.Cities).WithOne().HasForeignKey(x => x.RegionId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Location.City>().HasOne<Location.Country>().WithMany().HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.NoAction);

            /// RELATIONS 
            builder.Entity<Relations.RIdentityRole>().HasKey(x => new { x.IdIdentity, x.IdRole });
            builder.Entity<Relations.RIdentityRole>().HasOne(x => x.Identity)
                                                     .WithMany(x => x.Roles)
                                                     .HasForeignKey(x => x.IdIdentity)
                                                     .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Relations.RIdentityRole>().HasOne(x => x.Role)
                                                     .WithMany()
                                                     .HasForeignKey(x => x.IdRole)
                                                     .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Relations.ROrderProduct>().HasKey(x => new { x.IdOrder, x.IdProduct });
            builder.Entity<Relations.ROrderProduct>().HasOne(x => x.Order)
                                                     .WithMany(x => x.Products)
                                                     .HasForeignKey(x => x.IdOrder)
                                                     .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Relations.ROrderProduct>().HasOne(x => x.Product)
                                                     .WithMany()
                                                     .HasForeignKey(x => x.IdProduct)
                                                     .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Relations.RSupplierProduct>().HasKey(x => new { x.IdProduct, x.IdSupplier });
            builder.Entity<Relations.RSupplierProduct>().HasOne(x => x.Product)
                                                        .WithMany()
                                                        .HasForeignKey(x => x.IdProduct)
                                                        .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<Relations.RSupplierProduct>().HasOne(x => x.Supplier)
                                                        .WithMany()
                                                        .HasForeignKey(x => x.IdSupplier)
                                                        .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
