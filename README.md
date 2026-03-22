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
## Day 9 – Middleware & Request Pipeline

Learned how ASP.NET Core handles requests using middleware.

- Implemented a custom middleware
- Logged request path and response in the console
- Understood the request pipeline concept
  
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
###Day 15 – Entity Framework Core Setup

Learned how to connect ASP.NET Core application with database using Entity Framework Core.

Created Product model class
Created DbContext class
Added connection string in appsettings.json
Configured database in Program.cs
Connected project with Microsoft SQL Server

------
###Day 16 – Inventory CRUD (Create & Read)

Built a simple Inventory Management System using ASP.NET Core MVC.

Created ProductController
Implemented Create (Add Product)
Implemented Index (View Products)
Created Razor Views (Create & Index)
Stored and retrieved data using Entity Framework Core
Displayed data from Microsoft SQL Server

---------
###Day 17 – SQL Server Connection & DbContext
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

###Day 18 – CRUD Operations (MVC Project)
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
###Day 19 – Service Layer & Repository Pattern
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
