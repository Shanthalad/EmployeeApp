Employee Management System – ASP.NET MVC

📌 Project Overview

This is a sample ASP.NET Core MVC web application developed as part of a machine test.
The application demonstrates basic CRUD operations, MVC architecture, and client-side validation using JavaScript and jQuery.

The project manages employee data such as Name, Email, and Salary and follows clean coding and standard ASP.NET MVC folder structure.

🛠️ Technologies Used

ASP.NET Core MVC
C#
Visual Studio / VS Code
Razor Views (.cshtml)
JavaScript
jQuery
HTML5 & CSS3
Bootstrap
Git & GitHub

📂 Project Structure
EmployeeApp/
│
├── Controllers/
│   └── EmployeeController.cs
│
├── Models/
│   └── Employee.cs
│
├── Views/
│   ├── Employee/
│   │   ├── Index.cshtml
│   │   └── Create.cshtml
│   └── Shared/
│
├── wwwroot/
│   ├── css/
│   └── js/
│
├── Program.cs
├── EmployeeApp.csproj
└── README.md

✨ Features

Add new employee details
View employee list
Client-side form validation using JavaScript & jQuery
Clean MVC separation (Model, View, Controller)
Responsive UI using Bootstrap

🧪 Client-Side Validation

The application validates:
Name cannot be empty
Email must be in valid format
Salary must be numeric
Validation is handled using JavaScript and jQuery before form submission.

🚀 How to Run the Application
Clone the repository:
git clone https://github.com/Shanthalad/EmployeeApp.git


Navigate to the project folder:
cd EmployeeApp


Run the application:
dotnet run

Open browser and navigate to:
http://localhost:5000
or the port shown in the terminal.

📝 Notes
This project is created for learning and assessment purposes
Database integration can be added using SQL Server and Entity Framework
Server-side validation and authentication can be enhanced further

👩‍💻 Author
Shanthala D
Bachelor of Engineering – Computer Science
Aspiring Full Stack .NET Developer

📌 Purpose
This project was developed as part of a technical machine test to demonstrate:
ASP.NET MVC basics

Frontend validation

Code structure and logic implementation
