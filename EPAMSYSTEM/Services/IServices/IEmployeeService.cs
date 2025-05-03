using EPAMSYSTEM.Models;

namespace EPAMSYSTEM.Services.IServices
{
    public interface IEmployeeService
    {
        public string Registration(Employee employee); // done
        public string Login(); // done
        public string DayHightLight(); // done 
        public string AttendanceOfEmployee(); // done
        public string StartWork(); // done
        public string EndWork(); // done
        public string MonthlyTaskIsFinishedOfEmployee(); // done
        public string UpdateProfile(); // done
    }
}