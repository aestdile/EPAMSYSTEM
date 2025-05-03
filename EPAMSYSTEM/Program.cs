using System;
using EPAMSYSTEM.Services;
using EPAMSYSTEM.Models;

namespace EPAMSYSTEM
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n--------------Welcome to the EPAM SYSTEMS!-----------------\n");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Employee");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            ManagerService managerService = new ManagerService();
                            Console.Clear();
                            Console.WriteLine("\n--------------Welcome to the Manager Section!-----------------");
                            Console.WriteLine("1. Registration");
                            Console.WriteLine("2. Login");
                            Console.WriteLine("3. Back to Main Menu");
                            Console.WriteLine("------------------------------------------------------------\n");
                            Console.Write("Enter your choice: ");
                            string managerChoice = Console.ReadLine();
                            switch (managerChoice)
                            {
                                case "1":
                                    managerService.Registration(new Manager());
                                    managerService.Management();
                                    break;
                                case "2":
                                    managerService.Login();
                                    managerService.Management();
                                    break;
                                case "3":
                                    continue; // return to main page



                                default:
                                    Console.WriteLine("Invalid choice. Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        }

                    case "2":
                        {
                            AdminService adminService = new AdminService();
                            Console.Clear();
                            Console.WriteLine("\n--------------Welcome to the Admin Section!-----------------");
                            Console.WriteLine("1. Registration");
                            Console.WriteLine("2. Login");
                            Console.WriteLine("3. Back to Main Menu");
                            Console.WriteLine("------------------------------------------------------------\n");
                            Console.Write("Enter your choice: ");
                            string adminChoice = Console.ReadLine();
                            switch (adminChoice)
                            {
                                case "1":
                                    adminService.Registration(new Admin());
                                    adminService.ManagementOfAdmin();
                                    break;
                                case "2":
                                    adminService.Login();
                                    adminService.ManagementOfAdmin();
                                    break;
                                case "3":
                                    continue; // return to main page
                                default:
                                    Console.WriteLine("Invalid choice. Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        }

                    case "3":
                        {
                            EmployeeService employeeService = new EmployeeService();
                            Console.Clear();
                            Console.WriteLine("\n--------------Welcome to the Employee Section!-----------------");
                            Console.WriteLine("1. Registration");
                            Console.WriteLine("2. Login");
                            Console.WriteLine("3. Back to Main Menu");
                            Console.WriteLine("------------------------------------------------------------\n");
                            Console.Write("Enter your choice: ");
                            string employeeChoice = Console.ReadLine();
                            switch (employeeChoice)
                            {
                                case "1":
                                    employeeService.Registration(new Employee());
                                    employeeService.DayHightLight();
                                    break;
                                case "2":
                                    employeeService.Login();
                                    employeeService.DayHightLight();
                                    break;
                                case "3":
                                    continue; // return to main page
                                default:
                                    Console.WriteLine("Invalid choice. Press Enter to continue...");
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        }

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press Enter to continue...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}