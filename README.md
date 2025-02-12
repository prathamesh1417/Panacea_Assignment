# ASP.NET MVC User Management System

## Overview
This project is an ASP.NET MVC application that includes authentication and authorization, user management, and a dashboard.
It utilizes Entity Framework for database interaction and stores data in a SQL Server database.

## Features
- **User Authentication & Authorization**
  - Secure login page with username and password.
  - Role-based access control.
- **Dashboard**
  - Displays total number of users.
  - Shows count of active and inactive users.
- **User Management**
  - Add new users with required details.
  - Edit or delete users.
- **Menu Items**
  - Dashboard
  - User List
  - Logout
- **Responsive Design**
  - All pages are mobile-friendly.
  - Proper validation implemented for all forms.

## Installation Instructions
1. **Clone the Repository**
   ```sh
   git clone "https://github.com/prathamesh1417/Panacea_Assignment.git"
   ```
2. **Open the Project**
   - Navigate to the cloned folder and open `Panacea_Assignment.sln - Shortcut.lnk` in Visual Studio.

3. **Configure the Database**
   - Update `web.config` (for ASP.NET MVC) with your SQL Server connection string.
   - Run Entity Framework migrations to set up the database.

4. **Run the Application**
   - Press `Ctrl + F5` in Visual Studio to build and run the project.

## Database Schema
### Login Table:
- `Username` (string, unique, required)
- `Password` (string, hashed, required)
- `Role` (Admin/User)

### User Table:
- `FirstName`
- `MiddleName`
- `LastName`
- `Address`
- `PhoneNumber`
- `EmailID`
- `City`
- `State`
- `PinCode`
- `Username`
- `Password`
- `Status` (Active/Inactive)

## Technologies Used
- **ASP.NET MVC**
- **Entity Framework (Code-First Approach)**
- **SQL Server**
- **Bootstrap (for responsive UI)**
- **Identity Authentication & Authorization**


