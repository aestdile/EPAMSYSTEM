using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAMSYSTEM.Models;
using EPAMSYSTEM.Services.IServices;

namespace EPAMSYSTEM.Services
{
    public class ManagerService : IManagerService
    {
        public string FilePath { get; set; } = "manager.json";

        public string Registration(Manager manager)
        {
            Console.Clear();
            Console.WriteLine("------------------Manager Registration---------------------\n");

            /*--------------First Name----------------*/

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.Write("First name cannot be empty. Try again: ");
                }
                else if (firstName.Length < 3)
                {
                    Console.Write("First name must be at least 3 characters long. Try again: ");
                }
                else if (firstName.Length > 40)
                {
                    Console.Write("First name must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(firstName[0]))
                {
                    Console.Write("First name must start with an uppercase letter. Try again: ");
                }
                else if (!firstName.All(c => char.IsLetter(c)))
                {
                    Console.Write("First Name must contain only letters. Try again: ");
                }
                else
                {
                    manager.FirstName = firstName;
                    break;
                }
                firstName = Console.ReadLine();
            }

            /*--------------Last Name----------------*/

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.Write("Last name cannot be empty. Try again: ");
                }
                else if (lastName.Length < 3)
                {
                    Console.Write("Last name must be at least 3 characters long. Try again: ");
                }
                else if (lastName.Length > 40)
                {
                    Console.Write("Last name must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(lastName[0]))
                {
                    Console.Write("Last name must start with an uppercase letter. Try again: ");
                }
                else if (!lastName.All(c => char.IsLetter(c)))
                {
                    Console.Write("Last Name must contain only letters. Try again: ");
                }
                else
                {
                    manager.LastName = lastName;
                    break;
                }
                lastName = Console.ReadLine();
            }



            /*--------------Email----------------*/

            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.Write("Email cannot be empty. Please try again: ");
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.Write("Email must contain '@' and '.' characters. Please try again: ");
                }
                else
                {
                    manager.Email = email;
                    break;
                }
                email = Console.ReadLine();
            }

            /*--------------Password----------------*/

            Console.Write("Password: ");
            string password = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.Write("Password can not be empty!");
                }
                else if (password.Length < 8)
                {
                    Console.Write("Password can not be less 8 characters!");
                }
                else if (!password.Any(char.IsUpper))
                {
                    Console.Write("Password must contain at least one uppercase letter!");
                }
                else if (!password.Any(char.IsLower))
                {
                    Console.Write("Password must contain at least one lowercase letter!");
                }
                else if (!password.Any(char.IsDigit))
                {
                    Console.Write("Password must contain at leat one digit!");
                }
                else if (!password.Any(ch => "!@#$%^&*()-_=+[{]};:'\",<.>/?".Contains(ch)))
                {
                    Console.Write("Password must contain at least one special character!");
                }
                else
                {
                    manager.Password = password;
                    break;
                }
                password = Console.ReadLine();
            }


            /*----------------Salary----------------*/

            Console.Write("Salary: ");
            string salary = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(salary))
                {
                    Console.Write("Salary cannot be empty. Try again: ");
                }
                else if (!decimal.TryParse(salary, out decimal salaryValue))
                {
                    Console.Write("Salary must be a valid number. Try again: ");
                }
                else if (salaryValue < 0)
                {
                    Console.Write("Salary cannot be negative. Try again: ");
                }
                else
                {
                    manager.Salary = salaryValue;
                    break;
                }
                salary = Console.ReadLine();
            }


            /*----------------Date of Joining----------------*/

            Console.WriteLine("Date of Joining (yyyy-mm-dd): ");

            int joinYear, joinMonth, joinDay;

            Console.Write("Enter Year: ");
            string yearJoin = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(yearJoin, out joinYear))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid year. Please enter a valid number: ");
                }
                yearJoin = Console.ReadLine();
            }

            Console.Write("Enter Month (1 - 12): ");
            string monthJoin = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(monthJoin, out joinMonth))
                {
                    if (joinMonth >= 1 && joinMonth <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Month must be between 1 and 12. Try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid month. Enter a valid number: ");
                }
                monthJoin = Console.ReadLine();
            }

            Console.Write("Enter Day: ");
            string dayJoin = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(dayJoin, out joinDay))
                {
                    if (DateTime.TryParse($"{joinYear}-{joinMonth}-{joinDay}", out DateTime joiningDate))
                    {
                        if (joiningDate > DateTime.Now)
                        {
                            Console.Write("Date of Joining cannot be in the future. Try again: ");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("Invalid day for the given month/year. Try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid day. Enter a valid number: ");
                }
                dayJoin = Console.ReadLine();
            }
            manager.DateOfJoiningToCompany = new DateTime(joinYear, joinMonth, joinDay);


            Manager addManager = new Manager()
            {
                Id = Guid.NewGuid(),
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                Email = manager.Email,
                Password = manager.Password,
                Salary = manager.Salary,
                DateOfJoiningToCompany = manager.DateOfJoiningToCompany
            };

            List<Manager> managers = new List<Manager>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                managers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Manager>>(json) ?? new List<Manager>();
            }

            managers.Add(addManager);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(managers, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);

            Console.WriteLine($"{manager.FirstName} {manager.LastName} registered successfully!");

            return "Manager registration is successfull!";
        }


        /*-------------------------Login----------------------------*/

        public string Login()
        {
            Console.Clear();
            Console.WriteLine("------------------Manager Login---------------------\n");

            Console.Write("Your Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }

            /*--------------Password----------------*/

            Console.Write("Password: ");
            string password = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.Write("Password can not be empty!");
                }
                else if (password.Length < 8)
                {
                    Console.Write("Password can not be less 8 characters!");
                }
                else if (!password.Any(char.IsUpper))
                {
                    Console.Write("Password must contain at least one uppercase letter!");
                }
                else if (!password.Any(char.IsLower))
                {
                    Console.Write("Password must contain at least one lowercase letter!");
                }
                else if (!password.Any(char.IsDigit))
                {
                    Console.Write("Password must contain at leat one digit!");
                }
                else if (!password.Any(ch => "!@#$%^&*()-_=+[{]};:'\",<.>/?".Contains(ch)))
                {
                    Console.Write("Password must contain at least one special character!");
                }
                else
                {
                    break;
                }
                password = Console.ReadLine();
            }

            List<Manager> managers = new List<Manager>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                managers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Manager>>(json) ?? new List<Manager>();
            }

            Manager manager = managers.FirstOrDefault(m => m.Id == id && m.Password == password);
            if (manager != null)
            {
                return "Invalid Id or Password!";
            }
            Console.WriteLine($"Welcome {manager.FirstName} {manager.LastName}!");

            return "Login is successfull!";
        }


        /*-------------------------Update Profile----------------------------*/

        public string UpdateProfile()
        {
            Console.Clear();
            Console.WriteLine("------------------Update Profile---------------------\n");
            Console.Write("Your Id: ");
            string idInput = Console.ReadLine();
            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }


            /*--------------First Name----------------*/

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.Write("First name cannot be empty. Try again: ");
                }
                else if (firstName.Length < 3)
                {
                    Console.Write("First name must be at least 3 characters long. Try again: ");
                }
                else if (firstName.Length > 40)
                {
                    Console.Write("First name must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(firstName[0]))
                {
                    Console.Write("First name must start with an uppercase letter. Try again: ");
                }
                else if (!firstName.All(c => char.IsLetter(c)))
                {
                    Console.Write("First Name must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                firstName = Console.ReadLine();
            }

            /*--------------Last Name----------------*/

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.Write("Last name cannot be empty. Try again: ");
                }
                else if (lastName.Length < 3)
                {
                    Console.Write("Last name must be at least 3 characters long. Try again: ");
                }
                else if (lastName.Length > 40)
                {
                    Console.Write("Last name must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(lastName[0]))
                {
                    Console.Write("Last name must start with an uppercase letter. Try again: ");
                }
                else if (!lastName.All(c => char.IsLetter(c)))
                {
                    Console.Write("Last Name must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                lastName = Console.ReadLine();
            }



            /*--------------Email----------------*/

            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.Write("Email cannot be empty. Please try again: ");
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.Write("Email must contain '@' and '.' characters. Please try again: ");
                }
                else
                {
                    break;
                }
                email = Console.ReadLine();
            }

            /*--------------Password----------------*/

            Console.Write("Password: ");
            string password = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.Write("Password can not be empty!");
                }
                else if (password.Length < 8)
                {
                    Console.Write("Password can not be less 8 characters!");
                }
                else if (!password.Any(char.IsUpper))
                {
                    Console.Write("Password must contain at least one uppercase letter!");
                }
                else if (!password.Any(char.IsLower))
                {
                    Console.Write("Password must contain at least one lowercase letter!");
                }
                else if (!password.Any(char.IsDigit))
                {
                    Console.Write("Password must contain at leat one digit!");
                }
                else if (!password.Any(ch => "!@#$%^&*()-_=+[{]};:'\",<.>/?".Contains(ch)))
                {
                    Console.Write("Password must contain at least one special character!");
                }
                else
                {
                    break;
                }
                password = Console.ReadLine();
            }

            List<Manager> managers = new List<Manager>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                managers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Manager>>(json) ?? new List<Manager>();
            }
            Manager manager = managers.FirstOrDefault(m => m.Id == id);
            if (manager == null)
            {
                return "Manager not found!";
            }
            manager.FirstName = firstName;
            manager.LastName = lastName;
            manager.Email = email;
            manager.Password = password;
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(managers, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);
            Console.WriteLine($"{manager.FirstName} {manager.LastName} updated successfully!");

            return "Update Profile is successfull!";
        }


        /*-------------------------Management----------------------------*/

        public string Management()
        {
            Console.Clear();
            Console.WriteLine("------------------Management---------------------\n");


            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Get All Admins");
                Console.WriteLine("2. Get Admin By Id");
                Console.WriteLine("3. Remove Admin");
                Console.WriteLine("4. Update Admin");
                Console.WriteLine("5. KPI For Employees");
                Console.WriteLine("6. KPI For Admins");
                Console.WriteLine("7. Exit\n");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    GetAllAdmins();
                }
                else if (choice == "2")
                {
                    GetAdminById();
                }
                else if (choice == "3")
                {
                    RemoveAdmin();
                }
                else if (choice == "4")
                {
                    UpdateAdmin();
                }
                else if (choice == "5")
                {
                    KPIForEmployees();
                }
                else if (choice == "6")
                {
                    KPIForAdmins();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            return "Management is successfull!";
        }




        /*-------------------Get All Admins--------------------------*/


        public void GetAllAdmins()
        {
            Console.Clear();
            Console.WriteLine("------------------Get All Admins---------------------\n");

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }
            if (admins.Count == 0)
            {
                Console.WriteLine("No admins found.");
            }
            else
            {
                foreach (var admin in admins)
                {
                    Console.WriteLine($"Id: {admin.Id}, Name: {admin.FirstName} {admin.LastName}, Email: {admin.Email}");
                }
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }


        /*-------------------------Get Admin By Id-------------------------*/

        public Admin GetAdminById()
        {
            Console.Clear();
            Console.WriteLine("------------------Get Admin By Id---------------------\n");

            Console.Write("Enter Admin Id: ");
            string idInput = Console.ReadLine();
            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(a => a.Id == id);
            if (admin != null)
            {
                Console.WriteLine
                (
                    $"Id: {admin.Id}, " +
                    $"First Name: {admin.FirstName} " +
                    $"Last Name: {admin.LastName}, " +
                    $"Role: {admin.Role}, " +
                    $"Email: {admin.Email}" +
                    $"Department: {admin.Department}, " +
                    $"Salary: {admin.Salary}, " +
                    $"Date of Joining: {admin.DateOfJoiningToCompany}"
                );
            }
            else
            {
                Console.WriteLine("Admin not found.");
            }

            return admin;
        }


        /*-------------------------Remove Admin----------------------------*/

        public string RemoveAdmin()
        {
            Console.Clear();
            Console.WriteLine("------------------Remove Admin---------------------\n");

            Console.Write("Enter Admin Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin adminToRemove = admins.FirstOrDefault(a => a.Id == id);
            if (adminToRemove != null)
            {
                admins.Remove(adminToRemove);
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText("admin.json", jsonString);

                Console.WriteLine($"Admin {adminToRemove.FirstName} {adminToRemove.LastName} removed successfully!");
            }
            else
            {
                Console.WriteLine("Admin not found.");
            }

            return "Remove Admin is successfull!";
        }


        /*-------------------------Update Admin----------------------------*/

        public string UpdateAdmin()
        {
            Console.Clear();
            Console.WriteLine("------------------Update Admin---------------------\n");

            Console.Write("Enter Admin Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(a => a.Id == id);
            if (admin == null)
            {
                return "Admin not found!";
            }

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(role))
                {
                    Console.Write("Role cannot be empty. Try again: ");
                }
                else if (role.Length < 2)
                {
                    Console.Write("Role must be at least 2 characters long. Try again: ");
                }
                else if (role.Length > 40)
                {
                    Console.Write("Role must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(role[0]))
                {
                    Console.Write("Role must start with an uppercase letter. Try again: ");
                }
                else if (!role.All(c => char.IsLetter(c)))
                {
                    Console.Write("Role must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                role = Console.ReadLine();
            }

            Console.Write("Enter New Department: ");
            string department = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(department))
                {
                    Console.Write("Department cannot be empty. Try again: ");
                }
                else if (department.Length < 3)
                {
                    Console.Write("Department must be at least 3 characters long. Try again: ");
                }
                else if (department.Length > 40)
                {
                    Console.Write("Department must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(department[0]))
                {
                    Console.Write("Department must start with an uppercase letter. Try again: ");
                }
                else if (!department.All(c => char.IsLetter(c)))
                {
                    Console.Write("Department must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                department = Console.ReadLine();
            }

            Console.Write("Enter New Salary: ");
            string salary = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(salary))
                {
                    Console.Write("Salary cannot be empty. Try again: ");
                }
                else if (!decimal.TryParse(salary, out decimal salaryValue))
                {
                    Console.Write("Salary must be a valid number. Try again: ");
                }
                else if (salaryValue < 0)
                {
                    Console.Write("Salary cannot be negative. Try again: ");
                }
                else
                {
                    break;
                }
                salary = Console.ReadLine();
            }

            admin.Role = role;
            admin.Department = department;
            admin.Salary = decimal.Parse(salary);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("admin.json", jsonString);
            Console.WriteLine($"Admin {admin.FirstName} {admin.LastName} updated successfully!");

            return "Update Admin is successfull!";
        }




        /*-------------------------KPI For Employees----------------------------*/

        public string KPIForEmployees()
        {
            Console.Clear();
            Console.WriteLine("------------------KPI SYSTEM For Employees---------------------\n");

            Console.Write("Admin Id: ");
            string adminIdInput = Console.ReadLine();
            Guid adminId;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(adminIdInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(adminIdInput, out adminId))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                adminIdInput = Console.ReadLine();
            }

            Console.Write("Admin Department: ");
            string adminDepartment = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(adminDepartment))
                {
                    Console.Write("Department cannot be empty. Try again: ");
                }
                else if (adminDepartment.Length < 3)
                {
                    Console.Write("Department must be at least 3 characters long. Try again: ");
                }
                else if (adminDepartment.Length > 40)
                {
                    Console.Write("Department must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(adminDepartment[0]))
                {
                    Console.Write("Department must start with an uppercase letter. Try again: ");
                }
                else if (!adminDepartment.All(c => char.IsLetter(c) || c == ' '))
                {
                    Console.Write("Department must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                adminDepartment = Console.ReadLine();
            }


            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(a => a.Id == adminId && a.Department == adminDepartment);
            if (admin == null)
            {
                return "Admin not found!";
            }


            Console.Write("Employee Id: ");
            string idInput = Console.ReadLine();
            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(idInput, out id))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                idInput = Console.ReadLine();
            }

            List<Employee> employees = new List<Employee>();
            if (System.IO.File.Exists("employee.json"))
            {
                string json = System.IO.File.ReadAllText("employee.json");
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            Employee employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return "Employee not found!";
            }
            else if (employee.Attendance >= 24 && employee.MonthlyTaskIsFinished == true)
            {
                admin.NotificationsOfEmployee = $"{employee.Id}" +
                                                $"{employee.FirstName}" +
                                                $"{employee.LastName} 's works are super and increase his salary and update position";

            }
            else if (employee.Attendance >= 22 && employee.Attendance < 24 && employee.MonthlyTaskIsFinished == true)
            {
                employee.NotificationsForEmployee = $"Dear " +
                                                    $"{employee.Id}" +
                                                    $"{employee.FirstName}" +
                                                    $"{employee.LastName}! Your works are good." +
                                                    $"We ask you to participate in more work and work on yourself" +
                                                    $"This way we can upgrade your position and salary";
            }
            else if (employee.Attendance < 22 && employee.MonthlyTaskIsFinished == false)
            {
                employee.NotificationsForEmployee = $"Dear " +
                                                    $"{employee.Id}" +
                                                    $"{employee.FirstName}" +
                                                    $"{employee.LastName}! Your works are not good." +
                                                    $"We ask you to participate in more work and work on yourself";
            }

            return "KPI For Employee is successfull!";
        }


        /*-------------------------KPI For Admins----------------------------*/

        public string KPIForAdmins()
        {
            Console.Clear();
            Console.WriteLine("------------------KPI SYSTEM For Admins---------------------\n");

            Console.Write("Admin Id: ");
            string adminIdInput = Console.ReadLine();
            Guid adminId;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(adminIdInput))
                {
                    Console.Write("Id cannot be empty. Try again: ");
                }
                else if (!Guid.TryParse(adminIdInput, out adminId))
                {
                    Console.Write("Id must be a valid GUID. Try again: ");
                }
                else
                {
                    break;
                }
                adminIdInput = Console.ReadLine();
            }

            Console.Write("Admin Department: ");
            string adminDepartment = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(adminDepartment))
                {
                    Console.Write("Department cannot be empty. Try again: ");
                }
                else if (adminDepartment.Length < 3)
                {
                    Console.Write("Department must be at least 3 characters long. Try again: ");
                }
                else if (adminDepartment.Length > 40)
                {
                    Console.Write("Department must be less than 40 characters long. Try again: ");
                }
                else if (!char.IsUpper(adminDepartment[0]))
                {
                    Console.Write("Department must start with an uppercase letter. Try again: ");
                }
                else if (!adminDepartment.All(c => char.IsLetter(c)))
                {
                    Console.Write("Department must contain only letters. Try again: ");
                }
                else
                {
                    break;
                }
                adminDepartment = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists("admin.json"))
            {
                string json = System.IO.File.ReadAllText("admin.json");
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }
            Admin admin = admins.FirstOrDefault(a => a.Id == adminId && a.Department == adminDepartment);
            if (admin == null)
            {
                return "Admin not found!";
            }
            else if (admin.Attendance >= 24 && admin.MonthlyTask == true)
            {
                admin.NotificationsOfAdmin = $"Dear" +
                                                $"{admin.Id}" +
                                                $"{admin.FirstName}" +
                                                $"{admin.LastName} 's works are super and increase your salary and update position in the next month";
            }
            else if (admin.Attendance >= 22 && admin.Attendance < 24 && admin.MonthlyTask == true)
            {
                admin.NotificationsOfAdmin = $"Dear " +
                                                $"{admin.Id}" +
                                                $"{admin.FirstName}" +
                                                $"{admin.LastName}! Your works are good." +
                                                $"We ask you to participate in more work and work on yourself" +
                                                $"This way we can upgrade your position and salary";
            }
            else if (admin.Attendance < 22 && admin.MonthlyTask == false)
            {
                admin.NotificationsOfAdmin = $"Dear " +
                                                $"{admin.Id}" +
                                                $"{admin.FirstName}" +
                                                $"{admin.LastName}! Your works are not good." +
                                                $"We ask you to participate in more work and work on yourself";
            }

            return "KPI For Admins is successfull!";
        }
    }
}