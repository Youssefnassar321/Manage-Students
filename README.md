# Windows Forms Application for Student, Teacher, and Admin Management

## Overview
This is a **Windows Forms Application** developed in **C#** using **Entity Framework** and **SQL Server** to manage users with three different types of accounts: **Student**, **Teacher**, and **Admin**. The application provides user-specific functionality based on account type, including data management for students and teachers, with authentication and role-based access.

## Features

### General Features
- **Log In and Sign Up System**:
  - Three types of accounts: **Student**, **Teacher**, and **Admin**.
  - Role-based access controls and permissions.
  - Secure password creation during the first login (for students and teachers).
  
### Student Features:
- View personal data and academic information (degrees) using a **DataGridView**.
- Receive a username from the teacher and create a password upon first login.

### Teacher Features:
- Add, update, and delete **Student Data**.
- Manage students' grades (add, update, and delete).
- Search for students by **name** or **ID**.
- **Double-click on DataGridView rows** to update or delete student information.
- Receive a username from the admin and create a password upon first login.

### Admin Features:
- Full access to all teacher and student functionalities.
- Add new **Teacher accounts** with usernames.
- Admin can grant teacher access, and the teacher creates their own password on the first login.
- Manage teacher information.

## Technology Stack

### Backend:
- **C#** for core application logic and form handling.
- **Entity Framework Core** for data access and ORM functionality.
- **Microsoft SQL Server** for database management and storage.

### Frontend:
- **Windows Forms** for UI development.
- **DataGridView** for displaying and managing student data interactively.

### Design:
- **Photoshop** and **Canva** for UI logos and design elements.

### Authentication and Security:
- Role-based authentication for **Student**, **Teacher**, and **Admin** accounts.
- Password creation during first-time login for enhanced security.

## Setup and Installation

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Set up your SQL Server database and configure the connection string in the `appsettings.json` or the configuration file.
4. Run the Entity Framework Core migrations to set up the database schema.
   ```bash
   Update-Database
