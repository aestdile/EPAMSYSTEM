using System;
using System.Collections.Generic;
using EPAMSYSTEM.Models;

namespace EPAMSYSTEM.Services.IServices
{
    public interface IManagerService
    {
        public string Registration(Manager manager); // done
        public string Login(); // done
        public string UpdateProfile(); // done

        /*-------------------------------*/

        public string Management();
        public void GetAllAdmins();
        public Admin GetAdminById();
        public string RemoveAdmin();
        public string UpdateAdmin();
        public string KPIForEmployees();
        public string KPIForAdmins();
    }
}