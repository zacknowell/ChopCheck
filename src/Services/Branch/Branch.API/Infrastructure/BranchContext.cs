using Branch.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Branch.API.Infrastructure
{
    public class BranchContext : DbContext
    {
        public BranchContext(DbContextOptions<BranchContext> options) : base(options) { }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<BranchOpenHours> BranchOpenHours { get; set; }
        public DbSet<BranchServices> BranchServices { get; set; }
        public DbSet<BranchStaff> BranchStaff { get; set; }
        public DbSet<StaffStatus> BranchStaffStatus { get; set; }
    }
}