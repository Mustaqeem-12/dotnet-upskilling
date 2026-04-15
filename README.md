# .NET Upskilling 

This repository contains my daily practice and learning as part of a structured 4-week .NET upskilling plan.  
The focus is on building strong fundamentals in C# and .NET using console applications.

---

## Day 1 – .NET Basics & CLI
- Installed .NET SDK
- Understood .NET ecosystem
- Worked with .NET CLI commands:
  - dotnet new
  - dotnet run
  - dotnet build
- Created and ran first console application

---

## Day 2 – C# Basics
- Variables and data types
- Operators
- String interpolation
- Built simple console programs for practice

---

## Day 3 – Control Statements & Loops
- If / Else and Nested If
- Switch statement
- Looping statements:
  - for loop
  - while loop
  - foreach loop
- Practiced logical programs such as:
  - Pass / Fail & Grade calculation
  - Factorial
  - Sum of digits
  - Even and Odd number counting

---

## Day 4 – Methods & Exception Handling
- Created reusable methods
- Used parameters and return values
- Implemented try-catch for exception handling
- Built a CLI-based Calculator application with:
  - Addition
  - Subtraction
  - Multiplication
  - Division
  - Proper error handling (divide by zero)

---

## Technologies Used
- C#
- .NET SDK
- Console Applications
- Visual Studio
- .NET CLI

---

## How to Run
- Open the project in Visual Studio
- Run the console application (Ctrl + F5)
- Follow the instructions displayed in the terminal

---
## Day 5 – OOP (Class, Object, Constructor, Encapsulation)

In this task, I practiced basic OOP concepts in C#.

- Created an `Employee` class
- Created an object of the class
- Used a constructor to initialize employee details
- Implemented encapsulation using private fields and getter/setter methods
- Displayed employee information and updated salary using methods
  
- ----
  ## Day 6 – Inheritance, Polymorphism, Interfaces

Practiced OOP concepts in C#.

- Implemented inheritance using base and derived classes
- Used polymorphism with method overriding
- Implemented an interface for common functionality
- Created a small console program to understand OOP concepts
  
- -----
## Day 7 – Student CRUD Console Application

Created a console based Student Management System.

Features:
- Add Student
- View Students
- Update Student
- Delete Student
Used List collection to store student records and implemented CRUD operations using a menu.

-----
## Day 8 – ASP.NET Core MVC Basics

Learned the basic structure of ASP.NET Core MVC.

- Created a controller
- Added action methods
- Created a Razor view
- Displayed a simple page using MVC routing

- ---
##  Day 9 -- Improvements After Review
- Implemented proper runtime polymorphism using base type reference
- Replaced public fields with properties
- Added virtual and override methods
- Demonstrated polymorphism using List<IEmployee>
- Used constructors for object initialization
  
- ---
## Day 10 – Routing, Controllers & Actions

Practiced ASP.NET Core MVC routing.

- Created StudentController
- Added Info action method
- Created Razor view page
- Added Student page link in the navbar
- Accessed page using /Student/Info route
  
 ------
 ## Day 11 – Dependency Injection

-Created StudentService class and registered it in Program.cs.
-Injected the service into StudentController using Dependency Injection.
-Displayed message from service in Razor view.

-----
## Day 12 - Configuration & Logging
Learned how to use configuration and logging in ASP.NET Core.

- Stored application settings in appsettings.json
- Read configuration values using IConfiguration
- Implemented logging using ILogger
- Logged application events in the controller

  -------------
  ## Day 13 – Model Binding & Validation
Learned how ASP.NET Core handles form data using Model Binding and Validation.

- Created a Student model class
- Used Data Annotation attributes for validation
- Built a simple registration form
- Used model binding to map form data to the Student model
- Displayed validation messages for incorrect inputs

  ------------
  ## Day 14 – Simple Web API

Built a simple Student Web API with three endpoints.

- GET /api/student → get all students
- GET /api/student/{id} → get student by id
- POST /api/student → add new student

The API returns JSON responses and demonstrates basic REST API concepts.

--------
### Day 15 – Entity Framework Core Setup

Learned how to connect ASP.NET Core application with database using Entity Framework Core.

Created Product model class
Created DbContext class
Added connection string in appsettings.json
Configured database in Program.cs
Connected project with Microsoft SQL Server

------
### Day 16 – Inventory CRUD (Create & Read)

Built a simple Inventory Management System using ASP.NET Core MVC.

Created ProductController
Implemented Create (Add Product)
Implemented Index (View Products)
Created Razor Views (Create & Index)
Stored and retrieved data using Entity Framework Core
Displayed data from Microsoft SQL Server

---------
### Day 17 – SQL Server Connection & DbContext
Connected ASP.NET Core application with SQL Server
Configured connection string in appsettings.json
Used UseSqlServer in Program.cs
Created DbContext class
Added DbSet<Product> for database table
Understood how Entity Framework Core works
Ran migrations:
Add-Migration InitialCreate
Update-Database
Database and tables created successfully

-----

### Day 18 – CRUD Operations (MVC Project)
Built a Product Management system
Implemented full CRUD operations:
Create → Add new product
Read → Display product list
Update → Edit product details
Delete → Remove product
Created Controller with action methods
Created Razor Views (Create, Index, Edit, Delete)
Connected form data using Model Binding
Used Entity Framework for database operations
Understood complete MVC flow (Controller → View → Model)

-----
### Day 19 – Service Layer & Repository Pattern
Learned clean architecture concept
Separated logic into layers:
Controller → handles requests
Service → business logic
Repository → database operations
Created Repository Interface and Class
Created Service Interface and Class
Implemented Dependency Injection in Program.cs
Removed direct DbContext usage from Controller
Improved code structure and maintainability
Understood real-world project structure
## Note
This repository is updated daily as part of the learning plan to demonstrate consistency, logical thinking, and practical understanding of .NET concepts.

-------
## 🚀 Day 20 – JWT Authentication Setup

Today I worked on implementing JWT Authentication in my project.
- Added JWT configuration in appsettings.json
- Created token generation method in AuthController
- Used SymmetricSecurityKey and SigningCredentials
- Added claims (username) inside the token
- Set token expiry time (30 minutes)
Issue faced:
- Key size error (key must be greater than 256 bits)
Fix:
- Increased JWT secret key length

-------
## 🔐 Day 21 – Swagger Authorization Setup
Today I integrated JWT with Swagger UI.
- Added Swagger security definition (Bearer token)
- Configured AddSecurityRequirement
- Enabled Authorize button in Swagger
Issues faced:
- OpenApiSecurityScheme, Reference, ParameterLocation errors
Fix:
- Installed Swashbuckle.AspNetCore package
- Added using Microsoft.OpenApi.Models;

---------
## 🧪 Day 22 – Testing APIs with Token
Today I tested APIs using Swagger.
Steps:
1. Called /api/Auth/login
2. Got JWT token
3. Clicked Authorize in Swagger
4. Entered token

Issue:
- Entered "Bearer token" caused error
Fix:
- Entered only token (Swagger automatically adds Bearer)

Tested:
- GET Products
- POST Products
- PUT / DELETE

-------------
## ⚠️ Day 23 – Fixing Authorization Errors

Today I fixed authorization issues.
Error:
- 401 Unauthorized
- invalid_token
Reason:
- Token format was wrong (Bearer Bearer token)
Fix:
- Removed extra "Bearer"
Also checked:
- [Authorize] attribute working
- Middleware order:
  app.UseAuthentication();
  app.UseAuthorization();
  
## ✅ Final Result
- JWT Authentication working
- Swagger Authorization working
- All APIs secured
- Token-based access implemented

## 🧠 What I Learned
- JWT implementation in ASP.NET Core
- Securing APIs using token
- Swagger authorization setup
- Debugging authentication errors


--------------------------
## Day 24 – Async & Await

Learned Async and Await for non-blocking operations
Converted synchronous database calls to asynchronous
Used async/await with Task<T>
Implemented ToListAsync() in Entity Framework
Updated Repository, Service, and Controller layers
Improved API performance and scalability
Tested endpoints using Swagge

-------------------------
## Day 25 – Logging

Implemented built-in logging using ILogger
Added logs in API Controller
Logged API requests and responses
Tested logging in Visual Studio Output window
Understood basic concept of Serilog for file-based logging

-----------------
## Day 26 – Swagger (API Documentation)

Used Swagger to test APIs
Viewed all API endpoints in Swagger UI
Sent requests and received responses
Used Authorize option with JWT token
Added summary comments for API documentation
Understood how Swagger helps developers test and understand APIs

----------------------
# Day 27 – Employee Management (MVC)

## About Project
This is an ASP.NET Core MVC project where I built a simple Employee Management system.
I used MVC pattern to create UI pages for managing employees.

## Features
- View all employees
- Create new employee
- Edit employee details
- Delete employee
- View employee details
- Department dropdown selection

## Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap

## What I Learned
- How MVC works (Model, View, Controller)
- Passing data using ViewBag
- Using SelectList for dropdown
- Form handling (GET/POST)
- Basic CRUD operations

## How to Run
1. Open project in Visual Studio
2. Check connection string in `appsettings.json`
3. Run `Update-Database`
4. Run the project

## Notes
This project helped me understand how frontend (views) and backend connect in MVC.

---------------------------------

# Day 28 – Employee Management Web API

## About Project
This project is an extension of my MVC project.  
Here I built a Web API with JWT authentication.

## Features
- JWT Login Authentication
- Employee CRUD API
- SQL Server integration
- Swagger for testing API
- Validation
- Global exception handling

## Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger

## Authentication
Login API:

POST /api/Auth/login

Example:
{
  "username": "Employee",
  "password": "Emp1234"
}

After login, copy token and use in Swagger:
Bearer {token}

## API Endpoints
- GET /api/EmployeeApi
- POST /api/EmployeeApi
- PUT /api/EmployeeApi/{id}
- DELETE /api/EmployeeApi/{id}

## What I Learned
- How APIs work
- JWT authentication concept
- Using Swagger for testing
- Securing endpoints with [Authorize]
- Handling exceptions using middleware

## How to Run
1. Open project
2. Check connection string
3. Run `Update-Database`
4. Run the project
5. Open Swagger and test APIs

## Notes
This project helped me understand backend API development and authentication.
