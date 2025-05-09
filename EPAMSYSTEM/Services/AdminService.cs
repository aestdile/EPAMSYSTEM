﻿using System;
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


        /*----------------Add Employee----------------*/

        public string AddEmployee(Employee employee)
        {
            Console.Clear();
            Console.WriteLine("-----------Add Employee in Admin Service-----------\n");

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
                    employee.FirstName = firstName;
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
                    employee.LastName = lastName;
                    break;
                }
                lastName = Console.ReadLine();
            }

            /*--------------Age----------------*/

            Console.Write("Enter Age: ");
            string ageInput = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(ageInput))
                {
                    Console.Write("Age cannot be empty. Try again: ");
                }
                else if (!int.TryParse(ageInput, out int age))
                {
                    Console.Write("Age must be a valid number. Try again: ");
                }
                else if (age < 18 || age > 50)
                {
                    Console.Write("Age must be between 18 and 50. Try again: ");
                }
                else
                {
                    employee.Age = age;
                    break;
                }
                ageInput = Console.ReadLine();
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
                    employee.Email = email;
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
                    employee.Password = password;
                    break;
                }
                password = Console.ReadLine();
            }


            /*--------------Birth of date----------------*/

            Console.WriteLine("Date of Birth (yyyy-mm-dd): ");
            int year, month, day;

            Console.Write("Enter Year: ");
            string yearInput = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(yearInput, out year))
                {
                    if (year >= 1970 && year <= DateTime.Now.Year)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($"Year must be between 1970 and {DateTime.Now.Year}. Try again: ");
                    }
                }
                else
                {
                    Console.Write("Invalid year. Enter a valid number: ");
                }
                yearInput = Console.ReadLine();
            }

            Console.Write("Enter Month (1 - 12): ");
            string monthInput = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(monthInput, out month))
                {
                    if (month >= 1 && month <= 12)
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
                monthInput = Console.ReadLine();
            }

            Console.Write("Enter Day: ");
            string dayInput = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(dayInput, out day))
                {
                    if (DateTime.TryParse($"{year}-{month}-{day}", out DateTime kun))
                    {
                        employee.DateOfBirth = kun;
                        break;
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
                dayInput = Console.ReadLine();
            }
            employee.DateOfBirth = new DateTime(year, month, day);


            /*----------------Position----------------*/

            Console.Write("Position: ");
            string position = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(position))
                {
                    return "Position cannot be empty";
                }
                else if (position.Length < 3 || position.Length > 20)
                {
                    return "Position must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(position[0]))
                {
                    return "Position must start with an uppercase letter";
                }
                else if (position.Any(char.IsDigit))
                {
                    return "Position cannot contain numbers";
                }
                else if (position.Any(char.IsSymbol))
                {
                    return "Position cannot contain symbols";
                }
                else
                {
                    employee.Position = position;
                    break;
                }
                position = Console.ReadLine();
            }

            /*----------------Department----------------*/

            Console.Write("Department: ");
            string department = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(department))
                {
                    return "Department cannot be empty";
                }
                else if (department.Length < 3 || department.Length > 20)
                {
                    return "Department must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(department[0]))
                {
                    return "Department must start with an uppercase letter";
                }
                else if (department.Any(char.IsDigit))
                {
                    return "Department cannot contain numbers";
                }
                else if (department.Any(char.IsSymbol))
                {
                    return "Department cannot contain symbols";
                }
                else
                {
                    employee.Department = department;
                    break;
                }
                department = Console.ReadLine();
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
            employee.DateOfJoiningToCompany = new DateTime(joinYear, joinMonth, joinDay);


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
                    employee.Salary = salaryValue;
                    break;
                }
                salary = Console.ReadLine();
            }

            /* ------------- Json Part ---------------- */

            Employee addEmployee = new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Age = employee.Age,
                Email = employee.Email,
                Password = employee.Password,
                DateOfBirth = employee.DateOfBirth,
                Position = employee.Position,
                Department = employee.Department,
                DateOfJoiningToCompany = employee.DateOfJoiningToCompany,
                Salary = employee.Salary
            };

            List<Employee> employees = new List<Employee>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            employees.Add(addEmployee);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);

            Console.WriteLine($"{employee.FirstName} {employee.LastName} registered successfully!");

            return "Employee registered successfully";

        }


        /*----------------Get Admin By Id----------------*/

        public Admin GetAdminById()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Get Admin By Id------------------\n");

            Console.Write("Enter Employee Id: ");
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

            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id);

            if (admin == null)
            {
                Console.WriteLine("Admin not found.");
                return null;
            }
            else
            {
                Console.WriteLine($"Admin ID: {admin.Id}");
                Console.WriteLine($"First Name: {admin.FirstName}");
                Console.WriteLine($"Last Name: {admin.LastName}");
                Console.WriteLine($"Role: {admin.Role}");
                Console.WriteLine($"Email: {admin.Email}");
                Console.WriteLine($"Department: {admin.Department}");
                Console.WriteLine($"Salary: {admin.Salary}");
                Console.WriteLine($"Date of Joining: {admin.DateOfJoiningToCompany.ToShortDateString()}");
                Console.WriteLine($"Attendance: {admin.Attendance}");
            }

            return admin;
        }


        /*----------------Get Employee By Id----------------*/

        public Employee GetEmployeeById()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Get Employee By Id------------------\n");

            Console.Write("Enter Employee Id: ");
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

            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine($"Id: {employee.Id}");
                Console.WriteLine($"First Name: {employee.FirstName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Department: {employee.Department}");
                Console.WriteLine($"Date of Birth: {employee.DateOfBirth.ToShortDateString()}");
                Console.WriteLine($"Date of Joining: {employee.DateOfJoiningToCompany.ToShortDateString()}");
                Console.WriteLine($"Salary: {employee.Salary}");
            }

            return employee;
        }


        /*----------------Get All Employees----------------*/

        public void GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
            }
            else
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}, Email: {employee.Email}");
                }
            }
        }


        /*----------------Remove Employee----------------*/

        public string RemoveEmployee()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Remove Employee------------------\n");

            Console.Write("Enter Employee Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id can not be empty. Try again: ");
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
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            Employee employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine("Employee not found");
                return "Employee not found";
            }

            employees.Remove(employee);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);


            return "Employee removed successfully!";
        }


        /*----------------Update Profile of Employee----------------*/

        public string UpdateProfileOfEmployee()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Update Profile of Employee------------------\n");

            Console.Write("Enter Employee Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id can not be empty. Try again: ");
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

            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            Employee employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return "Employee not found";
            }

            Console.Write("Employee New Position: ");
            string newPosition = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(newPosition))
                {
                    Console.Write("Position cannot be empty. Try again: ");
                }
                else if (newPosition.Length < 3 || newPosition.Length > 20)
                {
                    Console.Write("Position must be between 3 and 20 characters. Try again: ");
                }
                else if (!char.IsUpper(newPosition[0]))
                {
                    Console.Write("Position must start with an uppercase letter. Try again: ");
                }
                else if (!newPosition.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    Console.Write("Position must only contain letters. Try again: ");
                }
                else
                {
                    employee.Position = newPosition;
                    break;
                }
                newPosition = Console.ReadLine();
            }

            Console.Write("Employee New Department: ");
            string newDepartment = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(newDepartment))
                {
                    Console.Write("Department cannot be empty. Try again: ");
                }
                else if (newDepartment.Length < 3 || newDepartment.Length > 20)
                {
                    Console.Write("Department must be between 3 and 20 characters. Try again: ");
                }
                else if (!char.IsUpper(newDepartment[0]))
                {
                    Console.Write("Department must start with an uppercase letter. Try again: ");
                }
                else if (!newDepartment.All(c => char.IsLetter(c) || c == ' '))
                {
                    Console.Write("Department must only contain letters. Try again: ");
                }
                else
                {
                    employee.Department = newDepartment;
                    break;
                }
                newDepartment = Console.ReadLine();
            }

            Console.Write("Employee New Salary: ");
            string newSalaryInput = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(newSalaryInput))
                {
                    Console.Write("Salary cannot be empty. Try again: ");
                }
                else if (!decimal.TryParse(newSalaryInput, out decimal newSalary))
                {
                    Console.Write("Salary must be a valid number. Try again: ");
                }
                else if (newSalary < 0)
                {
                    Console.Write("Salary cannot be negative. Try again: ");
                }
                else
                {
                    employee.Salary = newSalary;
                    break;
                }
                newSalaryInput = Console.ReadLine();
            }

            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);

            return $"Employee {employee.FirstName} {employee.LastName} updated successfully!";
        }


        /*----------------Update Profile of Admin----------------*/

        public string UpdateProfileOfAdmin()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Update Profile of Admin------------------\n");

            Console.Write("Your Id: ");
            string idInput = Console.ReadLine();

            Guid id;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.Write("Id can not be empty. Try again: ");
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
                    break;
                }
                lastName = Console.ReadLine();
            }


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
                    break;
                }
                email = Console.ReadLine();
            }

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

            Admin admin = admins.FirstOrDefault(e => e.Id == id);
            if (admin == null)
            {
                return "Admin not found";
            }

            admin.FirstName = firstName;
            admin.LastName = lastName;
            admin.Email = email;
            admin.Password = password;
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);


            return "Admin Profile updated successfully!";
        }


        /*----------------Get All Admins----------------*/

        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }


            return admins;
        }


        /*------------------Start Work--------------------------*/

        public string StartWork()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Start Work------------------\n");

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

            Console.WriteLine("Example (09:00:00): ");
            Console.Write("Start Work Time (hh:mm:ss): ");
            string startWorkInput = Console.ReadLine();

            TimeSpan startWork;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(startWorkInput))
                {
                    Console.Write("Start Work Time cannot be empty. Try again: ");
                }
                else if (!TimeSpan.TryParse(startWorkInput, out startWork))
                {
                    Console.Write("Start Work Time must be in hh:mm:ss format. Try again: ");
                }
                else
                {
                    break;
                }
                startWorkInput = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id);
            if (admin == null)
            {
                return "Admin not found";
            }

            admin.StartWorkTime = startWork;
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);


            return "Start Work is successfully!";
        }


        /*------------------End Work--------------------------*/

        public string EndWork()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------End Work------------------\n");

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

            Console.WriteLine("Example (17:00:00): ");
            Console.Write("End Work Time (hh:mm:ss): ");
            string endWorkInput = Console.ReadLine();

            TimeSpan endWork;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(endWorkInput))
                {
                    Console.Write("End Work Time cannot be empty. Try again: ");
                }
                else if (!TimeSpan.TryParse(endWorkInput, out endWork))
                {
                    Console.Write("End Work Time must be in hh:mm:ss format. Try again: ");
                }
                else
                {
                    break;
                }
                endWorkInput = Console.ReadLine();
            }


            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id);
            if (admin == null)
            {
                return "Admin not found";
            }

            admin.EndWorkTime = endWork;
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);

            return "End Work is successfully!";
        }


        /*------------------Attendance--------------------------*/

        public string AttendanceOfAdmin()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Attendance------------------\n");

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

            Console.Write("Attendance in this month: ");
            string attendance = Console.ReadLine();

            while (true)
            {
                if (string.IsNullOrWhiteSpace(attendance))
                {
                    Console.Write("Attendance cannot be empty. Try again: ");
                }
                else if (!int.TryParse(attendance, out int attendanceValue))
                {
                    Console.Write("Attendance must be a valid number. Try again: ");
                }
                else if (attendanceValue < 0)
                {
                    Console.Write("Attendance cannot be negative. Try again: ");
                }
                else
                {
                    break;
                }
                attendance = Console.ReadLine();
            }

            List<Admin> admins = new List<Admin>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id);
            if (admin == null)
            {
                return "Admin not found";
            }

            admin.Attendance = int.Parse(attendance);
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);


            return "Attendance is successfully!";
        }


        /*-------------------------Monthly Task----------------------------*/

        public string MonthlyTaskIsFinishedOfAdmin()
        {
            Console.Clear();
            Console.WriteLine("\n-----------------Monthly Task------------------\n");

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

            Console.Write("Monthly Task is Finished (true/false): ");
            string taskInput = Console.ReadLine();

            bool taskFinished;
            while (true)
            {
                if (string.IsNullOrWhiteSpace(taskInput))
                {
                    Console.Write("Monthly Task is Finished cannot be empty. Try again: ");
                }
                else if (!bool.TryParse(taskInput, out taskFinished))
                {
                    Console.Write("Monthly Task is Finished must be true or false. Try again: ");
                }
                else
                {
                    break;
                }
                taskInput = Console.ReadLine();
            }


            List<Admin> admins = new List<Admin>();

            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                admins = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Admin>>(json) ?? new List<Admin>();
            }

            Admin admin = admins.FirstOrDefault(e => e.Id == id);

            if (admin == null)
            {
                return "Admin not found";
            }

            admin.MonthlyTask = taskFinished;
            string jsonOutput = Newtonsoft.Json.JsonConvert.SerializeObject(admins, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonOutput);

            return "Monthly Task is successfully!";
        }
    }
}