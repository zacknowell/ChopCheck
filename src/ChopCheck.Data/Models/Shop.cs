using System;
using System.Collections.Generic;
using System.Text;
using ChopCheck.Data.Helpers;
using Patterns.Dapper;

namespace ChopCheck.Data.Models
{
    public class Shop
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string StreetNumber { get; set; }

        public string StreetName { get; set; }

        public int City { get; set; }

        public int County { get; set; }

        public int Country { get; set; }
    }
}
