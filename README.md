# TaskManagerApp 🚀

A role-based task management web application built with ASP.NET Core MVC, featuring user authentication, role-based access control, and full CRUD functionality.

![TaskManagerApp Screenshot](screenshots/dashboard.png) <!-- Add actual screenshot later -->

## Features ✨

- **User Authentication**
  - Registration and login system
  - Secure password hashing
  - Session management

- **Role-Based Access Control**
  - **User Role**: Create, view, update, and delete personal tasks
  - **Admin Role**: Manage all tasks and users through admin dashboard

- **Task Management**
  - Create tasks with title, description, and due dates
  - Mark tasks as complete/incomplete
  - Assign tasks to specific users (Admin only)

- **Admin Dashboard**
  - View all users and their tasks
  - Manage user roles
  - System-wide task overview

- **Responsive UI**
  - Clean Bootstrap interface
  - Mobile-friendly design
  - Interactive forms and tables

## Technologies Used 🛠️

- **Backend**
  - ASP.NET Core MVC
  - Entity Framework Core
  - ASP.NET Identity

- **Frontend**
  - Bootstrap 5
  - Razor Views
  - jQuery (for interactive components)

- **Database**
  - SQLite (Development)
  - SQL Server/PostgreSQL (Production-ready)

## Getting Started 🚦

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Code editor (VS Code, Visual Studio, Rider)
- SQLite (included with .NET) or SQL Server

### Installation
1. Clone the repository
   ```bash
     git clone https://github.com/yourusername/TaskManagerApp.git
     cd TaskManagerApp
     dotnet restore
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     dotnet run
