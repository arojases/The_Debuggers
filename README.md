# The_Debuggers

### CSE 325 – .NET Software Development | BYU-Idaho

Welcome to **The_Debuggers**, a collaborative software development repository created for our CSE 325 course at Brigham Young University–Idaho.

Our team works together to design, develop, and test a web application using .NET technologies.

## Our Project – SkillShare

**SkillShare – Learn, Teach, and Connect**

SkillShare is a web application that connects people who want to learn new skills with those willing to teach them.

The platform allows users to share their knowledge, discover learning opportunities, and connect with others who have similar interests.

### Key Features

- User registration and authentication
- User profile management
- Skill management (CRUD)
- Skill search and filtering
- Learning requests
- Personal dashboard

## Technologies

- **Language:** C#
- **Framework:** ASP.NET Core MVC
- **Database:** SQL Server or SQLite
- **ORM:** Entity Framework Core
- **Frontend:** HTML, CSS, Bootstrap
- **Version Control:** Git & GitHub
- **Project Management:** Jira

## Development Workflow

Our team follows a collaborative development process:

1. Organize requirements and tasks using Jira.
2. Create Git branches for individual features.
3. Develop and test assigned functionality.
4. Submit pull requests for code review.
5. Merge approved changes into the main branch.

## Team

**The_Debuggers**

We collaborate on software design, implementation, testing, and documentation.

## Project Status

**Current Phase:** Planning and Requirements Definition

This project is being developed as part of CSE 325 – .NET Software Development at BYU-Idaho, Fall 2026.

## How to connect and update database
download the EF

> dotnet tool install --global dotnet-ef

Set the connection string to supabase project.

> dotnet user-secrets set "ConnectionStrings:DefaultConnection" 'Host=aws-1-us-west-2.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.jjgyulmtkeqjlghjjlko;Password=YOURDATABASEPASSWORDHERE;SSL Mode=Require'

This lists your connectionstrings to help you check your connection.

> dotnet user-secrets list

This is how you update tables in supabase

> dotnet ef migrations add //describe the changes like git commit -m "
> dotnet ef database update