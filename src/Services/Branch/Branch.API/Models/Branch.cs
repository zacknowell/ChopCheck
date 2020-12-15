namespace Branch.API.Model
{
    public class Branch
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
