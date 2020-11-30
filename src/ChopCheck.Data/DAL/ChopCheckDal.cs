namespace ChopCheck.Data.DAL
{
    using System;
    using ChopCheck.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ChopCheckContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
    }
}
