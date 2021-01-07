using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Branch.API.Models
{
    public class BranchOpenHoursOverride
    {
        public int Id { get; set; }

        public Branches Branch { get; set; }

        public DateTime OverrideDate { get; set; }
    }
}
