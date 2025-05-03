

using System;
using System.Collections.Generic;
using EPAMSYSTEM.Models;

namespace EPAMSYSTEM.Services.IServices
{
    public interface IAdminService
    {
        public string Registration(Admin admin); // done
        public string Login(); // done
        public string ManagementOfAdmin(); // done
        public string UpdateProfileOfAdmin(); // done
        public string AddEmployee(Employee employee); // done
        public string RemoveEmployee(); // done
        public string UpdateProfileOfEmployee(); // done
        public void GetAllEmployees(); // done
        public Employee GetEmployeeById(); // done
        public List<Admin> GetAllAdmins(); // done
        public Admin GetAdminById(); // done
        public string StartWork(); // done
        public string EndWork(); // done    
        public string MonthlyTaskIsFinishedOfAdmin();  // done
        public string AttendanceOfAdmin(); // done
    }
}
