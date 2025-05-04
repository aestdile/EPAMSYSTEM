# 🏢 EPAMSYSTEM - OOP Based Company Management Console App (C#)

**EPAMSYSTEM** — bu C# tilida yozilgan **Object-Oriented Programming (OOP)** asosidagi to'liq **kompaniya boshqaruv tizimi**, unda Manager, Admin va Employee rollari o'zaro aloqada ishlaydi.

---

## 🧱 Arxitektura

```
EPAMSYSTEM/
│
├── Models/
│   ├── Admin.cs
│   ├── Employee.cs
│   └── Manager.cs
│
├── Services/
│   └── IServices/
│       ├── IAdminService.cs
│       ├── IEmployeeService.cs
│       └── IManagerService.cs
│
│   ├── AdminService.cs
│   ├── EmployeeService.cs
│   └── ManagerService.cs
│
├── Program.cs
└── README.md
```

---

## ⚙️ Rollar va Ularga Tegishli Metodlar

### 👨‍💼 **Manager**
- **Auth:**
  - `Registration()`, `Login()`
- **Admin Management:**
  - `Management()`
  - `GetAllAdmins()`, `GetAdminById()`
  - `RemoveAdmin()`, `UpdateAdmin()`
- **Performance Management:**
  - `KPIForEmployees()`
  - `KPIForAdmins()`
- **Profile Management:**
  - `UpdateProfile()`

---

### 👤 **Admin**
- **Auth:**
  - `Registration()`, `Login()`
- **Employee Management:**
  - `AddEmployee()`, `RemoveEmployee()`
  - `UpdateProfileOfEmployee()`, `GetAllEmployees()`, `GetEmployeeById()`
- **Admin Management:**
  - `ManagementOfAdmin()`, `UpdateProfileOfAdmin()`
  - `GetAllAdmins()`, `GetAdminById()`
- **Work Management:**
  - `StartWork()`, `EndWork()`
  - `MonthlyTaskIsFinishedOfAdmin()`
  - `AttendanceOfAdmin()`

---

### 👨‍💻 **Employee**
- **Auth:**
  - `Registration()`, `Login()`
- **Work Management:**
  - `DayHightLight()`
  - `AttendanceOfEmployee()`
  - `StartWork()`, `EndWork()`
  - `MonthlyTaskIsFinishedOfEmployee()`
- **Profile Management:**
  - `UpdateProfile()`

---

## 📦 Modellar: Propertylar

### Admin
- Id (Guid)
- FirstName 
- LastName
- Role
- Email
- Password
- Department
- Salary
- DateOfJoiningToCompany
- Attendance
- StartWorkTime
- EndWorkTime
- MonthlyTask
- NotificationsOfAdmin
- NotificationsOfEmployee

### Employee
- Id (Guid)
- FirstName
- LastName
- Age
- Email
- Password
- DateOfBirth
- Position
- Department
- DateOfJoiningToCompany
- Salary
- Attendance
- StartWork
- EndWork
- MonthlyTaskIsFinished
- NotificationsForEmployee

### Manager
- Id (Guid)
- FirstName
- LastName
- Email
- Password
- Salary
- DateOfJoiningToCompany

---

## 💡 CRUD Prinsiplari

| Rol      | Create | Read | Update | Delete |
| -------- | ------ | ---- | ------ | ------ |
| Manager  | ✅     | ✅   | ✅     | ✅     |
| Admin    | ✅     | ✅   | ✅     | ✅     |
| Employee | ✅     | ✅   | ✅     | ❌     |

---

## 📘 Texnologiyalar

- 🧠 C# (Console Application)
- 📦 OOP: Abstraction, Encapsulation, Inheritance, Polymorphism
- 📂 Ma'lumotlar Json orqali saqlanadi 

---

## 📝 Misol Ko'rinish (Console UI)

```
Welcome to EPAMSYSTEM!
1. Login as Manager
2. Login as Admin
3. Login as Employee
4. Exit
>> 2
-- ADMIN PANEL --
1. Manage Employees
2. Manage Profile
3. View Attendance
4. Manage Task
5. Exit
```

---

## 📚 Rekomendatsiya

- Loyihani modul tarzida rivojlantiring, interfeyslar orqali mustahkamlashni unutmang.
- Har bir xizmat alohida xizmat klassida bo'lishi — Clean Architecture tamoyiliga mos.

---

## ✍️ Muallif
👤 Mukhtor Eshboyev\
🔗 GitHub: [@aestdile](https://github.com/aestdile)\
📌 "When you finish this project, upload it to GitHub and send me the repository link, I'll wait for it!"
---

> Ushbu loyiha kompaniya boshqaruvi, xodimlar hisobi va ish jarayonlarini avtomatlashtirish uchun mo'ljallangan.
