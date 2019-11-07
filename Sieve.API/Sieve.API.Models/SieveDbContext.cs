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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Storage.Category>().HasBaseType<Storage.CategorySection>();
            builder.Entity<Storage.Category>().HasOne(x => x.Section).WithMany();
            builder.Entity<Storage.Section>().HasBaseType<Storage.CategorySection>();
            builder.Entity<Storage.Product>().HasOne(x => x.Category).WithMany();
            builder.Entity<Storage.Product>().HasOne(x => x.Section).WithMany();


        }
    }
}
