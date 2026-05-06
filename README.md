# Advanced Routing MVC Application

## Overview

This project demonstrates advanced routing techniques in ASP.NET Core MVC.  
The application includes:

- Complex routing scenarios
- Dynamic routing based on conditions
- Custom route constraints
- Route testing using browser endpoints

The project is developed using ASP.NET Core MVC and .NET 10.0.

---

# Features

## 1. Complex Routing

Implemented routes such as:

```text
/Products/{category}/{id}
/Users/{username}/Orders
```

These routes demonstrate handling multiple route parameters dynamically.

---

## 2. Dynamic Routing

Implemented dynamic routing based on user roles.

Example:

```text
/Dashboard/admin
/Dashboard/user
```

Admin users and normal users receive different responses.

---

## 3. Custom Route Constraints

Implemented a custom GUID route constraint.

Example:

```text
/GuidTest/{id}
```

Only valid GUID values are accepted.

---

# Technologies Used

- ASP.NET Core MVC
- C#
- .NET 10.0
- Visual Studio

---

# Project Structure

```text
AdvancedRoutingMVC
│
├── Controllers
│   ├── DashboardController.cs
│   ├── GuidController.cs
│   ├── HomeController.cs
│   ├── ProductController.cs
│   └── UserController.cs
│
├── Constraints
│   └── GuidConstraint.cs
│
├── Views
│   ├── Product
│   │   └── Details.cshtml
│   │
│   ├── User
│   │   └── Orders.cshtml
│   │
│   └── Shared
│
├── wwwroot
│
├── Program.cs
└── AdvancedRoutingMVC.csproj
```

---

# Routes Implemented

## Product Route

```text
/Products/Electronics/101
```

Displays product details using category and product ID.

---

## User Orders Route

```text
/Users/shadab/Orders
```

Displays orders for a specific user.

---

## Dashboard Route

```text
/Dashboard/admin
/Dashboard/user
```

Demonstrates dynamic routing based on role.

---

## GUID Constraint Route

### Valid Example

```text
/GuidTest/550e8400-e29b-41d4-a716-446655440000
```

### Invalid Example

```text
/GuidTest/123
```

Invalid GUID values return 404 Not Found.

---

# How to Run the Project

1. Open the solution in Visual Studio
2. Build the project
3. Run the application using:

```text
Ctrl + F5
```

4. Test the routes in the browser

---

# User Stories Covered

## User Story 1
Implemented complex routing scenarios.

## User Story 2
Implemented dynamic routing based on user role.

## User Story 3
Implemented custom route constraints.

## User Story 4
Tested all routing scenarios successfully.

---

# Learning Outcome

This project provides hands-on experience with:

- ASP.NET Core MVC routing
- Attribute routing
- Dynamic route handling
- Custom route constraints
- Route validation
- MVC application structure

---
