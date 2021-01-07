using System;
using Branch.API.Models;

namespace Queue.API.Models
{
    public class QueueServices
    {
        public int Id { get; set; }

        public Queue Queue { get; set; }

        public Services Service { get; set; }
    }
}
