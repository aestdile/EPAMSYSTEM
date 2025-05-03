using System;

namespace EPAMSYSTEM.Models
{
    public class Manager
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoiningToCompany { get; set; }
    }
}