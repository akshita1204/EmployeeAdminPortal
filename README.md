# EmployeeAdminPortal

**Implemented as part of Week 2 of my internship**

This repository contains a backend solution for managing employee data, built with **ASP.NET Core Web API ( .NET 8 )** and **Entity Framework Core**, featuring full **CRUD (Create, Read, Update, Delete)** functionality.

---

##  Features

- **Create** new employee records  
- **Read** (retrieve) all employees or a specific employee by ID  
- **Update** existing employee information  
- **Delete** employee records  
- Built using **ASP.NET Core Web API**  
- Data layer handled via **Entity Framework Core** (Code-First approach)

---

##  Technologies & New in .NET 8 / EF Core 8

- **ASP.NET Core Web API (.NET 8)** – modern, high-performance, cross-platform web API framework :contentReference[oaicite:0]{index=0}  
- **Entity Framework Core 8** – adds powerful new features like JSON column support and improved complex-type handling:contentReference[oaicite:1]{index=1}

---

##  Project Structure

- `Models/` – C# classes defining your domain models (e.g., `Employee`)  
- `Data/` – includes the `DbContext` configuration and EF Core migrations  
- `Controllers/` – API endpoints for employee operations (GET, POST, PUT, DELETE)  
- `Program.cs` – application bootstrapping, middleware, and service registrations (e.g., `DbContext`)  

---

##  Getting Started

1. **Clone the repository**

   ```bash
   git clone https://github.com/akshita1204/EmployeeAdminPortal.git
   cd EmployeeAdminPortal
