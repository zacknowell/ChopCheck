namespace ChopCheck.Data.DAL
{
    using System;
    using ChopCheck.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ChopCheckContext : DbContext
    {
        public ChopCheckContext(DbContextOptions<ChopCheckContext> options) : base(options)
        {
        }

        public DbSet<Shop> Shops { get; set; }
    }
}
