using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Branch.API.Models
{
    public class BranchServices
    {
        public int Id { get; set; }

        public Branches Branch { get; set; }

        public Services Services { get; set; }

        public decimal Cost { get; set; }
    }
}