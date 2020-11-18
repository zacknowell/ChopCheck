using System;
using System.Collections.Generic;
using System.Text;
using ChopCheck.Data.Dapper;
using ChopCheck.Data.Helpers;
using Patterns.Dapper;

namespace ChopCheck.Data.Models
{
    [DapperTable("Shop")]
    public class Shop : BaseModel, IDapperModel
    {
        [DapperColumn("Id", typeof(int), Identity = true)]
        public int Id { get; set; }

        [DapperColumn("Name", typeof(int))]
        public int Name { get; set; }

        [DapperColumn("Latitude", typeof(double))]
        public double Latitude { get; set; }

        [DapperColumn("Longitude", typeof(double))]
        public double Longitude { get; set; }

        [DapperColumn("StreetNumber", typeof(string))]
        public string StreetNumber { get; set; }

        [DapperColumn("StreetName", typeof(string))]
        public string StreetName { get; set; }

        [DapperColumn("City", typeof(int))]
        public int City { get; set; }

        [DapperColumn("County", typeof(int))]
        public int County { get; set; }

        [DapperColumn("Country", typeof(int))]
        public int Country { get; set; }
    }
}
