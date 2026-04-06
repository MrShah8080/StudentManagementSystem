# Student Management System API

This project is a simple Student Management System built using ASP.NET Core Web API. It allows users to perform basic CRUD operations on student data.

----------------------------------------

## Features

- Get all students
- Add new student
- Update existing student
- Delete student

----------------------------------------

## Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger (API Testing)

----------------------------------------

## Architecture

This project follows a layered architecture:

- Controller Layer → Handles API requests
- Service Layer → Business logic
- Repository Layer → Database operations

----------------------------------------

## Setup Instructions

1. Clone the repository
2. Open the project in Visual Studio
3. Update connection string in appsettings.json
4. Run the following commands in Package Manager Console:

   add-migration Init  
   update-database

5. Run the project

----------------------------------------

## Authentication

Login API:

POST: /api/auth/login

Username: admin  
Password: 123  

After login, copy the JWT token and use it in Swagger Authorize.

----------------------------------------

## Notes

- All APIs are secured using JWT Authentication
- Proper exception handling middleware is implemented
- Swagger is enabled for testing APIs

----------------------------------------

## Author

Seraj Ahmad
