# Freelancing BD 🇧🇩

A desktop-based **Freelancing Platform** built with **C# (Windows Forms)** and **SQL Server**, developed as an academic project for **CSC2210: Object Oriented Programming 2** at **American International University–Bangladesh (AIUB)**.

The platform connects freelancers with companies, allowing job posting, bidding, hiring, and payment management through a clean GUI-based desktop application.

---

## 👥 Team Members

| Name | Student ID |
|------|-----------|
| MD. HISHAMUR RAHMAN | 24-57939-2 |
| MD. TALIMUL ISLAM UTSHA | 23-52908-2 |

**Supervised by:** Dr. Md. Iftekharul Mobin
**Course:** CSC2210 — Object Oriented Programming 2
**Section:** K | Spring 2025–2026

---

## 📌 Features

### 🔐 Admin
- Manage freelancer and company accounts (ban/remove)
- Monitor all platform transactions
- View ratings and reports
- Earn commission from successful transactions

### 🏢 Company
- Register and log in
- Post job listings (title, description, salary, deadline)
- View and manage job applications
- Hire freelancers and make payments
- Rate employees after job completion

### 💼 Freelancer (Employee)
- Register with personal, professional, and educational details
- Browse and search available jobs
- Apply for jobs with a cover letter
- Track application status
- Receive payments and ratings

---

## 🛠️ Technologies Used

| Technology | Purpose |
|------------|---------|
| C# (.NET Framework) | Core application logic (OOP) |
| Windows Forms | Graphical User Interface (GUI) |
| SQL Server | Relational database management |
| T-SQL | Stored procedures and queries |
| ADO.NET | Database connectivity |

---

## 🗄️ Database Structure

The database (`fbd`) is implemented in SQL Server with the following core tables:

| Table | Description |
|-------|-------------|
| `admin` | Administrator login credentials |
| `profilef` | Freelancer personal, professional, and educational info |
| `company` | Company account details |
| `job` | Job listings posted by companies |
| `application` | Freelancer job applications (links freelancer ↔ job) |

---

## 🚀 How to Run

1. Clone the repository: `git clone https://github.com/talimulutsha/Freelancing_BD.git`
2. Open the `.sln` solution file inside the `freelance bd` folder in **Visual Studio**
3. Open **SQL Server Management Studio (SSMS)**, create a database named `fbd` and run the SQL scripts
4. Update the **connection string** in the source code to match your SQL Server instance
5. Press **F5** in Visual Studio to build and run

---

## 📁 Project Structure

Freelancing_BD/
├── freelance bd/               # Main C# Windows Forms project
├── c#Projectfinalreport.docx   # Full academic project report
└── README.md

---

## 📄 Project Report

The complete academic project report is included in the repository:
📎 [c#Projectfinalreport.docx](./c%23Projectfinalreport.docx)

---

## 📷 Screenshots

Key screens in the application:
- Login Page (Admin / Company / Freelancer)
- Freelancer Registration & Profile
- Company Registration
- Job Dashboard
- Job Application & Status Tracking

---

## 👨‍💻 Developers

**MD. Talimul Islam Utsha** — [@talimulutsha](https://github.com/talimulutsha)
**MD. Hishamur Rahman**

---

## 📜 License

This project is developed for **academic and educational purposes** only — AIUB, Spring 2025–2026.
