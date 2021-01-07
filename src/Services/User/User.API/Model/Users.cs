namespace User.API.Models
{
    using System;

    public class Users
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string HashPassword { get; set; }
    }
}