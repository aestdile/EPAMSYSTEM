

using System;
using System.Collections.Generic;
using System.Linq;
using EPAMSYSTEM.Models;
using EPAMSYSTEM.Services.IServices;

namespace EPAMSYSTEM.Services
{
    public class EmployeeService : IEmployeeService
    {
        public string FilePath { get; set; } = "employees.json";

        /*-------------------Registration----------------------*/
        public string Registration(Employee employee)
        {
            Console.Clear();
            Console.WriteLine("-----------Employee Registration-----------\n");

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


        /*----------------Login----------------*/

        public string Login()
        {
            Console.Clear();
            Console.WriteLine("------------Employee Login---------------\n");

            /*------------------Id----------------------*/

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


            List<Employee> employees = new List<Employee>();
            if (System.IO.File.Exists(FilePath))
            {
                string json = System.IO.File.ReadAllText(FilePath);
                employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(json) ?? new List<Employee>();
            }

            Employee employee = employees.FirstOrDefault(e => e.Id == id && e.Password == password);
            if (employee == null)
            {
                return "Invalid Id or Password";
            }
            Console.WriteLine($"Welcome, {employee.FirstName} {employee.LastName}!");


            return "Login is successfull!";
        }


        /*----------------Day Highlight----------------*/

        public string DayHightLight()
        {
            Console.Clear();
            Console.WriteLine("------------Day Highlight---------------\n");

            while (true)
            {
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("1. Attendance");
                Console.WriteLine("2. Start Work");
                Console.WriteLine("3. End Work");
                Console.WriteLine("4. Monthly Task is Finished");
                Console.WriteLine("5. Update Profile");
                Console.WriteLine("6. Exit\n");
                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AttendanceOfEmployee();
                        break;
                    case "2":
                        StartWork();
                        break;
                    case "3":
                        EndWork();
                        break;
                    case "4":
                        MonthlyTaskIsFinishedOfEmployee();
                        break;
                    case "5":
                        UpdateProfile();
                        break;
                    case "6":
                        return "Exited from Day Highlight menu.";
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }


        /*----------------Attendance----------------*/

        public string AttendanceOfEmployee()
        {
            Console.Clear();
            Console.WriteLine("------------Attendance Employee---------------\n");
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
            employee.Attendance = int.Parse(attendance);
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);


            return "Attendance updated successfully";
        }


        /*----------------Start Work----------------*/

        public string StartWork()
        {
            Console.Clear();
            Console.WriteLine("------------Start Work Employee---------------\n");
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
            employee.StartWork = startWork;
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);


            return "Start Work updated successfully";
        }


        /*----------------End Work----------------*/

        public string EndWork()
        {
            Console.Clear();
            Console.WriteLine("------------End Work Employee---------------\n");

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
            employee.EndWork = endWork;
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(FilePath, jsonString);


            return "End Work updated successfully";
        }


    }
}