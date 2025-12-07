# ASP.NET Core Web API CRUD - Student Management

A simple and clean ASP.NET Core Web API for managing student records with full CRUD operations. Built with Entity Framework Core and SQL Server, this project demonstrates how to create a robust RESTful API for real-world applications. Perfect for learning modern C# Web API development or integrating into larger projects.

## Features
Create new student records
Read all students or a single student by ID
Update existing student information
Delete student records
Built using Entity Framework Core with Database-First or Code-First approach

Uses SQL Server for persistent storage
Follows clean architecture with controllers and models

## Technologies Used
ASP.NET Core Web API (.NET 8)
Entity Framework Core
SQL Server 
C#

## Getting Started
Clone the repository:
git clone [(https://github.com/ShahzadSyed/ASPCoreWebAPICRUD)]


Update the connection string in appsettings.json to point to your SQL Server database.

Run migrations (if using Code-First) or scaffold the database (Database-First).

Start the project and test API endpoints using Postman or Swagger.

| Method | Endpoint             | Description                |
| ------ | -------------------- | -------------------------- |
| GET    | /api/StudentAPI      | Get all students           |
| GET    | /api/StudentAPI/{id} | Get student by ID          |
| POST   | /api/StudentAPI      | Create a new student       |
| PUT    | /api/StudentAPI/{id} | Update an existing student |
| DELETE | /api/StudentAPI/{id} | Delete a student           |
