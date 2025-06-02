# 📚 My Library Management System

A C# Windows Forms desktop application for managing books and borrowers in a library. The system connects to a SQL Server database, allowing for persistent book and borrower data. Screenshots are included for reference.

---

## ✅ Features

### 🔐 Login
- Secure login form with validation.
- **Default credentials:**  
  - **Username:** `admin`  
  - **Password:** `password123`

### 📘 Book Management
- Add, edit, delete books.
- View book lists and details.

### 👤 Borrower Management
- Register new borrowers.
- Update or remove borrower records.

### 📤 Book Issuing & Returning
- Issue books to registered borrowers.
- Return books and track late returns.

### 🔍 Search Functionality
- Search for books by various criteria.

---

## 🖼 Screenshots

You can view the app's interface inside the `Screenshots/` folder included in the repository.

Example:
![Main Menu](Screenshots/Screenshot 2025-06-01 224532.png)

---

## 🗄️ Database Setup

A SQL script `MyLibrayDB.sql` is included to set up the necessary database schema.

### Steps:

1. Open **SQL Server Management Studio**.
2. Create a new database, e.g., `LibraryDB`.
3. Execute the contents of `MyLibrayDB.sql` to create tables and seed default data.
4. Update your connection string in the project if needed.

---

### 📦 Prerequisites

- [Visual Studio 2019+](https://visualstudio.microsoft.com/)
- [.NET Framework 4.7.2 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
- [SQL Server Express or higher](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

Made By Selman Mohammed 
         ID:1501463
