🏢 EPAMSYSTEM - OOP Based Company Management Console App (C#)
<div style="background-color: #1e3a8a; padding: 15px; border-radius: 10px; margin-bottom: 20px; color: white;">
<h2 style="color: #ffdd00; margin-top: 0;">📋 Loyiha haqida</h2>
<p><b>EPAMSYSTEM</b> — bu C# tilida yozilgan <b>Object-Oriented Programming (OOP)</b> asosidagi to'liq <b>kompaniya boshqaruv tizimi</b>, unda Manager, Admin va Employee rollari o'zaro aloqada ishlaydi.</p>
</div>
<div style="display: flex; gap: 10px; margin-bottom: 20px;">
  <span style="background-color: #239120; color: white; padding: 8px 12px; border-radius: 5px; font-weight: bold;">C#</span>
  <span style="background-color: #5C2D91; color: white; padding: 8px 12px; border-radius: 5px; font-weight: bold;">.NET</span>
  <span style="background-color: #000000; color: white; padding: 8px 12px; border-radius: 5px; font-weight: bold;">Console</span>
  <span style="background-color: #0078d7; color: white; padding: 8px 12px; border-radius: 5px; font-weight: bold;">OOP</span>
  <span style="background-color: #e34c26; color: white; padding: 8px 12px; border-radius: 5px; font-weight: bold;">CRUD</span>
</div>

<div style="background-color: #0d2e4d; padding: 15px; border-radius: 10px; margin-bottom: 20px; color: white;">
<h2 style="color: #4cc9f0; margin-top: 0;">🧱 Arxitektura</h2>
<div style="background-color: #16425b; padding: 15px; border-radius: 8px; font-family: monospace; white-space: pre;">
EPAMSYSTEM/
│
├── <span style="color: #fca311;">Models/</span>
│   ├── <span style="color: #e07a5f;">Admin.cs</span>
│   ├── <span style="color: #e07a5f;">Employee.cs</span>
│   └── <span style="color: #e07a5f;">Manager.cs</span>
│
├── <span style="color: #fca311;">Services/</span>
│   └── <span style="color: #80ed99;">IServices/</span>
│       ├── <span style="color: #48cae4;">IAdminService.cs</span>
│       ├── <span style="color: #48cae4;">IEmployeeService.cs</span>
│       └── <span style="color: #48cae4;">IManagerService.cs</span>
│
│   ├── <span style="color: #80ed99;">AdminService.cs</span>
│   ├── <span style="color: #80ed99;">EmployeeService.cs</span>
│   └── <span style="color: #80ed99;">ManagerService.cs</span>
│
├── <span style="color: #f72585;">Program.cs</span>
└── <span style="color: #f72585;">README.md</span>
</div>
</div>

<div style="background-color: #242423; padding: 15px; border-radius: 10px; margin-bottom: 20px; color: white;">
<h2 style="color: #fcbf49; margin-top: 0;">⚙️ Rollar va Ularga Tegishli Metodlar</h2>
<div style="background-color: #003566; padding: 15px; border-radius: 8px; margin-bottom: 15px;">
<h3 style="color: #ffd60a; margin-top: 0;">👨‍💼 Manager</h3>
<div style="background-color: #1c448e; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">🔑 Auth:</p>
  <p style="margin: 5px 0 0 15px; color: #8ecae6;">
    <code>Registration()</code>, <code>Login()</code>
  </p>
</div>
<div style="background-color: #1c448e; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">👮 Admin Management:</p>
  <p style="margin: 5px 0 0 15px; color: #8ecae6;">
    <code>Management()</code>, <code>GetAllAdmins()</code>, <code>GetAdminById()</code>, <code>RemoveAdmin()</code>, <code>UpdateAdmin()</code>
  </p>
</div>
<div style="background-color: #1c448e; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">📊 Performance Management:</p>
  <p style="margin: 5px 0 0 15px; color: #8ecae6;">
    <code>KPIForEmployees()</code>, <code>KPIForAdmins()</code>
  </p>
</div>
<div style="background-color: #1c448e; padding: 10px; border-radius: 6px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">👤 Profile Management:</p>
  <p style="margin: 5px 0 0 15px; color: #8ecae6;">
    <code>UpdateProfile()</code>
  </p>
</div>
</div>
<div style="background-color: #6a994e; padding: 15px; border-radius: 8px; margin-bottom: 15px;">
<h3 style="color: #f1faee; margin-top: 0;">👤 Admin</h3>
<div style="background-color: #386641; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">🔑 Auth:</p>
  <p style="margin: 5px 0 0 15px; color: #a7c957;">
    <code>Registration()</code>, <code>Login()</code>
  </p>
</div>
<div style="background-color: #386641; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">👥 Employee Management:</p>
  <p style="margin: 5px 0 0 15px; color: #a7c957;">
    <code>AddEmployee()</code>, <code>RemoveEmployee()</code>, <code>UpdateProfileOfEmployee()</code>, <code>GetAllEmployees()</code>, <code>GetEmployeeById()</code>
  </p>
</div>
<div style="background-color: #386641; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">👮 Admin Management:</p>
  <p style="margin: 5px 0 0 15px; color: #a7c957;">
    <code>ManagementOfAdmin()</code>, <code>UpdateProfileOfAdmin()</code>, <code>GetAllAdmins()</code>, <code>GetAdminById()</code>
  </p>
</div>
<div style="background-color: #386641; padding: 10px; border-radius: 6px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">🕒 Work Management:</p>
  <p style="margin: 5px 0 0 15px; color: #a7c957;">
    <code>StartWork()</code>, <code>EndWork()</code>, <code>MonthlyTaskIsFinishedOfAdmin()</code>, <code>AttendanceOfAdmin()</code>
  </p>
</div>
</div>
<div style="background-color: #ef476f; padding: 15px; border-radius: 8px;">
<h3 style="color: #f1faee; margin-top: 0;">👨‍💻 Employee</h3>
<div style="background-color: #b5179e; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">🔑 Auth:</p>
  <p style="margin: 5px 0 0 15px; color: #ffccd5;">
    <code>Registration()</code>, <code>Login()</code>
  </p>
</div>
<div style="background-color: #b5179e; padding: 10px; border-radius: 6px; margin-bottom: 10px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">🕒 Work Management:</p>
  <p style="margin: 5px 0 0 15px; color: #ffccd5;">
    <code>DayHightLight()</code>, <code>AttendanceOfEmployee()</code>, <code>StartWork()</code>, <code>EndWork()</code>, <code>MonthlyTaskIsFinishedOfEmployee()</code>
  </p>
</div>
<div style="background-color: #b5179e; padding: 10px; border-radius: 6px;">
  <p style="color: #EDF2F4; margin: 0; font-weight: bold;">👤 Profile Management:</p>
  <p style="margin: 5px 0 0 15px; color: #ffccd5;">
    <code>UpdateProfile()</code>
  </p>
</div>
</div>
</div>

<div style="background-color: #4a4e69; padding: 15px; border-radius: 10px; margin-bottom: 20px; color: white;">
<h2 style="color: #f2cc8f; margin-top: 0;">📦 Modellar: Propertylar</h2>
<div style="display: flex; flex-wrap: wrap; gap: 20px;">
  <div style="background-color: #22223b; padding: 15px; border-radius: 8px; flex: 1; min-width: 250px;">
    <h3 style="color: #f77f00; margin-top: 0; text-align: center;">Admin</h3>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 10px;">
      <span style="color: #ffbe0b; font-weight: bold;">⚙️ Id:</span> <span style="color: #a8dadc;">Guid</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 FirstName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 LastName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🏷️ Role</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📧 Email</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔑 Password</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🏢 Department</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">💰 Salary</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📅 DateOfJoiningToCompany</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">✓ Attendance</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">⏰ StartWorkTime</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">⏰ EndWorkTime</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📋 MonthlyTask</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔔 NotificationsOfAdmin</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔔 NotificationsOfEmployee</span>
    </div>
  </div>
  <div style="background-color: #22223b; padding: 15px; border-radius: 8px; flex: 1; min-width: 250px;">
    <h3 style="color: #00b4d8; margin-top: 0; text-align: center;">Employee</h3>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 10px;">
      <span style="color: #ffbe0b; font-weight: bold;">⚙️ Id:</span> <span style="color: #a8dadc;">Guid</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 FirstName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 LastName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔢 Age</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📧 Email</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔑 Password</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🎂 DateOfBirth</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🏷️ Position</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🏢 Department</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📅 DateOfJoiningToCompany</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">💰 Salary</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">✓ Attendance</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">⏰ StartWork</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">⏰ EndWork</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📋 MonthlyTaskIsFinished</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔔 NotificationsForEmployee</span>
    </div>
  </div>
  <div style="background-color: #22223b; padding: 15px; border-radius: 8px; flex: 1; min-width: 250px;">
    <h3 style="color: #fb8b24; margin-top: 0; text-align: center;">Manager</h3>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 10px;">
      <span style="color: #ffbe0b; font-weight: bold;">⚙️ Id:</span> <span style="color: #a8dadc;">Guid</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 FirstName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">👤 LastName</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📧 Email</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">🔑 Password</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px; margin-bottom: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">💰 Salary</span>
    </div>
    <div style="background-color: #4a4e69; padding: 10px; border-radius: 5px;">
      <span style="color: #ffbe0b; font-weight: bold;">📅 DateOfJoiningToCompany</span>
    </div>
  </div>
</div>
</div>

<div style="background-color: #1f2041; padding: 15px; border-radius: 10px; margin-bottom: 20px; color: white;">
<h2 style="color: #ffc857; margin-top: 0;">💡 CRUD Prinsiplari</h2>
<div style="overflow-x: auto;">
  <table style="width: 100%; border-collapse: collapse; color: white; background-color: #1f2041;">
    <thead>
      <tr style="background-color: #4b3f72;">
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Rol</th>
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Create</th>
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Read</th>
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Update</th>
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Delete</th>
        <th style="padding: 12px; border: 2px solid #ffc857; text-align: center;">Ruxsat darajasi</th>
      </tr>
    </thead>
    <tbody>
      <tr style="background-color: #119da4;">
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-weight: bold;">Manager</td>
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-size: 20px;">✅</td>
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-size: 20px;">✅</td>
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-size: 20px;">✅</td>
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-size: 20px;">✅</td>
        <td style="padding: 10px; border: 1px solid #4b3f72; text-align: center; font-size: 20px;">
          <span style="color: #ffd100;">🔑🔑🔑</span>
        </td>

📘 Texnologiyalar

🧠 C# (Console Application)
📦 OOP: Abstraction, Encapsulation, Inheritance, Polymorphism
📂 Ma'lumotlar List orqali saqlanadi (Json yoki SQL versiyaga kengaytirilishi mumkin)

🔄 Tizim ishlatilish sikli
mermaidsequenceDiagram
    participant User as Foydalanuvchi
    participant System as Tizim
    participant DB as Ma'lumotlar
    
    User->>System: Tizimga kirish
    alt Manager
        System->>User: Manager panel
        User->>System: Admin va xodimlarni boshqarish
    else Admin
        System->>User: Admin panel
        User->>System: Xodimlarni boshqarish
    else Employee
        System->>User: Employee panel
        User->>System: Ish vazifalarini boshqarish
    end
    
    User->>System: Ma'lumot so'rovi
    System->>DB: Ma'lumotlarni olish
    DB->>System: Ma'lumotlar qaytarildi
    System->>User: Ma'lumotlar ko'rsatildi
    
    User->>System: Yangilash/qo'shish/o'chirish
    System->>DB: Ma'lumotlarni yangilash
    DB->>System: Amaliyot natijasi
    System->>User: Natija ko'rsatildi

📝 Misol Ko'rinish (Console UI)
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

📚 Rekomendatsiya

List<T> bilan boshlang, so'ng Json yoki SQL bilan kengaytirish mumkin.
Loyihani modul tarzida rivojlantiring, interfeyslar orqali mustahkamlashni unutmang.
Har bir xizmat alohida xizmat klassida bo'lishi — Clean Architecture tamoyiliga mos.

🚀 Rivojlantirish bosqichlari
mermaidgraph TB
    A[Loyiha boshlash] --> B[Model klasslarni yaratish]
    B --> C[Interfeys va servislarni ishlab chiqish]
    C --> D[Asosiy dastur logikasini yaratish]
    D --> E[Konsolga chiqarish va UI yaratish]
    E --> F[Testlash va xatolarni tuzatish]
    F --> G[Ma'lumotlarni saqlash mexanizmini qo'shish]
    G --> H[Qo'shimcha funksionalliklar]
    
    classDef green fill:#93c47d,stroke:#82b366,stroke-width:2px;
    classDef blue fill:#6fa8dc,stroke:#6c8ebf,stroke-width:2px;
    class A,B,C green;
    class D,E,F,G,H blue;

✍️ Muallif
👤 Sizning ismingiz
🔗 GitHub: @sizning_github_profilingiz
📌 "Loyihani tugallangandan so'ng, uni GitHub'ga yuklang va repository havolasini yuboring!"
