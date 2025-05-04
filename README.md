# 🏢 EPAMSYSTEM - Company Management Console App (C# OOP)

![C#](https://img.shields.io/badge/C%23-.NET-blue) ![Console App](https://img.shields.io/badge/Platform-Console-orange) ![OOP](https://img.shields.io/badge/Architecture-OOP-green) ![CRUD](https://img.shields.io/badge/Operations-CRUD-yellow)

## 📋 Loyiha haqida

**EPAMSYSTEM** — bu C# dasturlash tilida, **Object-Oriented Programming (OOP)** tamoyillari asosida ishlab chiqilgan **kompaniya boshqaruv tizimi** bo‘lib, unda 3 ta asosiy rol mavjud:

- 👨‍💼 **Manager**
- 👤 **Admin**
- 👨‍💻 **Employee**

Ushbu tizim orqali foydalanuvchilar ro‘yxatdan o‘tishi, profilini boshqarishi, ish faoliyatini yuritishi va xodimlar ustidan monitoring olib borishi mumkin.

---

## 🧱 Loyihaning Arxitekturasi

EPAMSYSTEM/
│
├── Models/
│ ├── Admin.cs
│ ├── Employee.cs
│ └── Manager.cs
│
├── Services/
│ ├── IServices/
│ │ ├── IAdminService.cs
│ │ ├── IEmployeeService.cs
│ │ └── IManagerService.cs
│ ├── AdminService.cs
│ ├── EmployeeService.cs
│ └── ManagerService.cs
│
├── Program.cs
└── README.md


---

## ⚙️ Rollar va Ularga Tegishli Funksiyalar

### 👨‍💼 Manager

- 🔐 **Auth**: `Registration()`, `Login()`
- 👮 **Admin Management**: `Management()`, `GetAllAdmins()`, `GetAdminById()`, `RemoveAdmin()`, `UpdateAdmin()`
- 📊 **Performance Management**: `KPIForEmployees()`, `KPIForAdmins()`
- 👤 **Profile**: `UpdateProfile()`

---

### 👤 Admin

- 🔐 **Auth**: `Registration()`, `Login()`
- 👥 **Employee Management**: `AddEmployee()`, `RemoveEmployee()`, `UpdateProfileOfEmployee()`, `GetAllEmployees()`, `GetEmployeeById()`
- 👮 **Admin Management**: `ManagementOfAdmin()`, `UpdateProfileOfAdmin()`, `GetAllAdmins()`, `GetAdminById()`
- 🕒 **Work Management**: `StartWork()`, `EndWork()`, `MonthlyTaskIsFinishedOfAdmin()`, `AttendanceOfAdmin()`

---

### 👨‍💻 Employee

- 🔐 **Auth**: `Registration()`, `Login()`
- 🕒 **Work Management**: `StartWork()`, `EndWork()`, `DayHighlight()`, `AttendanceOfEmployee()`, `MonthlyTaskIsFinishedOfEmployee()`
- 👤 **Profile**: `UpdateProfile()`

---

## 🧩 Modellar

### Admin / Manager / Employee uchun umumiy propertylar:

| Property      | Tipi  | Tavsif                  |
|---------------|-------|--------------------------|
| `Id`          | Guid  | Unikal identifikator     |
| `FirstName`   | string| Ismi                     |
| `LastName`    | string| Familiyasi               |
| `Email`       | string| Elektron pochta manzili |
| `Password`    | string| Parol                    |
| `Role`        | enum  | Foydalanuvchi roli       |

---

## 📈 KPI Tizimi

- `StartTime` va `EndTime` asosida ish soatlari hisoblanadi.
- Har oy uchun `Attendance` va `DailyTask` natijalari KPIga ta'sir qiladi.
- KPI natijalariga ko‘ra:
  - 👑 Eng yaxshi xodimlar manager tomonidan ko‘rib chiqiladi.
  - 🔁 Lavozim, maosh va bo‘lim o‘zgarishi mumkin.

---

## 🗂 CRUD Qo‘llab-quvvatlovi

EPAMSYSTEM loyihasi barcha asosiy CRUD funksiyalarini o‘z ichiga oladi:

- **Create** — Foydalanuvchi, Admin yoki Manager qo‘shish
- **Read** — Ma'lumotlarni ko‘rish
- **Update** — Profil yoki ish faoliyatini yangilash
- **Delete** — Ma'lumotlarni tizimdan o‘chirish

---

## 📦 Texnologiyalar

- 💻 C# (.NET 6.0+)
- 📦 OOP Arxitekturasi
- 🖥 Console Application
- 📁 JSON asosida ma’lumot saqlash

---

## 🚀 Loyihani Ishga Tushurish

1. **Projectni klon qiling:**

```bash
git clone https://github.com/your-username/EPAMSYSTEM.git
```

2. **Visual Studio / Rider orqali oching**

3. **Program.cs faylidan loyihani ishga tushiring**

## ✍️ Muallif
👤 Mukhtor Eshboyev\
🔗 GitHub: [@aestdile](https://github.com/aestdile)\
📌 "When you finish this project, upload it to GitHub and send me the repository link, I'll wait for it!"

## 📫 Bog‘lanish uchun:
<div align="center">
  <a href="https://t.me/aestdile"><img src="https://img.shields.io/badge/Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white" /></a>
  <a href="https://github.com/aestdile"><img src="https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white" /></a>
  <a href="https://leetcode.com/aestdile"><img src="https://img.shields.io/badge/LeetCode-FFA116?style=for-the-badge&logo=leetcode&logoColor=black" /></a>
  <a href="https://linkedin.com/in/aestdile"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white" /></a>
  <a href="https://youtube.com/@aestdile"><img src="https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white" /></a>
  <a href="https://instagram.com/aestdile"><img src="https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white" /></a>
  <a href="https://facebook.com/aestdile"><img src="https://img.shields.io/badge/Facebook-1877F2?style=for-the-badge&logo=facebook&logoColor=white" /></a>
  <a href="mailto:aestdile@gmail.com"><img src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" /></a>
</div>


