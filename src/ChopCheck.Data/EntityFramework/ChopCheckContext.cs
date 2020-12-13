namespace ChopCheck.Data.EntityFramework
{
    using System;
    using ChopCheck.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ChopCheckContext : DbContext
    {
        public ChopCheckContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().ToTable("Branch");
        }
    }
}
