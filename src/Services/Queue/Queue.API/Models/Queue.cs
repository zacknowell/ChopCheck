using System;
using User.API.Models;
using Branch.API.Models;

namespace Queue.API.Models
{
    public class Queue
    {
        public int Id { get; set; }

        public Users User { get; set; }

        public Branches Branch { get; set; }

        public DateTime CreatedWhen { get; set; }
    }
}
