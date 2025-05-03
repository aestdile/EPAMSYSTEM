

using System;

namespace EPAMSYSTEM.Models
{
    public class Admin
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoiningToCompany { get; set; }
        public int Attendance { get; set; }
        public TimeSpan StartWorkTime { get; set; }
        public TimeSpan EndWorkTime { get; set; }
        public bool MonthlyTask { get; set; }
        public string NotificationsOfAdmin { get; set; }
        public string NotificationsOfEmployee { get; set; }
    }
}