namespace Branch.API.Models
{
    using System;

    public class BranchOpenHours
    {
        public int Id { get; set; }

        public Branches Branch { get; set; }

        public int DayOfWeek { get; set; }

        public DateTime OpenTime { get; set; }

        public DateTime CloseTime { get; set; }
    }
}