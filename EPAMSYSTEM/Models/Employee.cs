using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMSYSTEM.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public DateTime DateOfJoiningToCompany { get; set; }
        public decimal Salary { get; set; }
        public int Attendance { get; set; }
        public TimeSpan StartWork { get; set; }
        public TimeSpan EndWork { get; set; }
        public bool MonthlyTaskIsFinished { get; set; }
        public string NotificationsForEmployee { get; set; }
    }
}