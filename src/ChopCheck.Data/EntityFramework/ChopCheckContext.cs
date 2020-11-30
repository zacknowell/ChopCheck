namespace ChopCheck.Data.EntityFramework
{
    using System;
    using ChopCheck.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ChopCheckContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().ToTable("Shop");
        }
    }
}
