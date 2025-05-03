using System;
using System.Collections.Generic;
using System.Linq;
using EPAMSYSTEM.Models;
using EPAMSYSTEM.Services.IServices;

namespace EPAMSYSTEM.Services
{
    public class AdminService : IAdminService
    {
        public string FilePath { get; set; } = "admins.json";

        public string Registration(Admin admin)
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Admin Registration------------------\n");

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
                    admin.FirstName = firstName;
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
                else if (lastName.Length < 4)
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
                    admin.LastName = lastName;
                    break;
                }
                lastName = Console.ReadLine();
            }

            /*--------------Role----------------*/

            Console.WriteLine("HR, IT, Finance, SuperAdmin");
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
                    admin.Role = role;
                    break;
                }
                role = Console.ReadLine();
            }


            /*--------------Email----------------*/

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.Write("Email cannot be empty. Try again: ");
                }
                else if (email.Length < 5)
                {
                    Console.Write("Email must be at least 5 characters long. Try again: ");
                }
                else if (email.Length > 40)
                {
                    Console.Write("Email must be less than 40 characters long. Try again: ");
                }
                else if (!email.Contains("@"))
                {
                    Console.Write("Email must contain '@'. Try again: ");
                }
                else
                {
                    admin.Email = email;
                    break;
                }
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
                    admin.Password = password;
                    break;
                }
                password = Console.ReadLine();
            }


            /*--------------Department----------------*/

            Console.Write("Enter Department: ");
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
                    admin.Department = department;
                    break;
                }
                department = Console.ReadLine();
            }


            /*--------------Salary----------------*/

            Console.Write("Enter Salary: ");
            string salaryInput = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(salaryInput))
                {
                    Console.Write("Salary cannot be empty. Try again: ");
                }
                else if (!decimal.TryParse(salaryInput, out decimal salary))
                {
                    Console.Write("Invalid salary format. Try again: ");
                }
                else if (salary < 0)
                {
                    Console.Write("Salary cannot be negative. Try again: ");
                }
                else
                {
                    admin.Salary = salary;
                    break;
                }
                salaryInput = Console.ReadLine();
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
            admin.DateOfJoiningToCompany = new DateTime(joinYear, joinMonth, joinDay);


            Admin addAdmin = new Admin()
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName,
                Role = admin.Role,
                Email = admin.Email,
                Password = admin.Password,
                Department = admin.Department,
                Salary = admin.Salary,
                DateOfJoiningToCompany = admin.DateOfJoiningToCompany
            };

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            admins.Add(addAdmin);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);

            Console.WriteLine($"{admin.FirstName} {admin.LastName} registered successfully!");

            return "Admin Registration is succesfully!";
        }


        public string Login()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Admin Login---------------------\n");

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

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id && e.Password == password);
            if (admin == null)
            {
                return "Invalid Id or Password";
            }
            Console.WriteLine($"Welcome, {admin.FirstName} {admin.LastName}!");

            return "Login is successfully!";
        }


        public string ManagementOfAdmin()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Management of Admin------------------\n");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Get All Employees");
                Console.WriteLine("5. Get Employee By ID");
                Console.WriteLine("6. Get All Admins");
                Console.WriteLine("7. Get Admin By ID");
                Console.WriteLine("8. Update Profile");
                Console.WriteLine("9. Start Work");
                Console.WriteLine("10. End Work");
                Console.WriteLine("11. Monthly Task Is Finished");
                Console.WriteLine("12. Attendance");
                Console.WriteLine("13. Exit\n");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Employee employee = new Employee();
                    AddEmployee(employee);
                }
                else if (choice == "2")
                {
                    RemoveEmployee();
                }
                else if (choice == "3")
                {
                    UpdateProfileOfEmployee();
                }
                else if (choice == "4")
                {
                    GetAllEmployees();
                }
                else if (choice == "5")
                {
                    GetEmployeeById();
                }
                else if (choice == "6")
                {
                    GetAllAdmins();
                }
                else if (choice == "7")
                {
                    GetAdminById();
                }
                else if (choice == "8")
                {
                    UpdateProfileOfAdmin();
                }
                else if (choice == "9")
                {
                    StartWork();
                }
                else if (choice == "10")
                {
                    EndWork();
                }
                else if (choice == "11")
                {
                    MonthlyTaskIsFinishedOfAdmin();
                }
                else if (choice == "12")
                {
                    AttendanceOfAdmin();
                }
                else if (choice == "13")
                {
                    Console.WriteLine("Exiting.....");
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

            return "Management of Admin is succesfully!";
        }



    }
}