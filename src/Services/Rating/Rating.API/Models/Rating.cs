using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Branch.API.Models;

namespace Rating.API.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public Branches Branch { get; set; }
    }
}
