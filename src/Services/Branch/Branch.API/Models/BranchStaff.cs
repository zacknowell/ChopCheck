namespace Branch.API.Models
{
    using User.API.Models;
    public class BranchStaff
    {
        public int Id { get; set; }

        public Branches Branch { get; set; }

        public Users User { get; set; }

        public StaffStatus StaffStatus { get; set; }
    }
}