# SkillShare

SkillShare is a web application developed by The Debuggers for CSE 325 - .NET Software Development at BYU-Idaho.

## Project Overview

SkillShare connects people who want to learn new skills with people who are willing to teach them.

## Technologies

- C#
- Blazor Web App (.NET 10)
- ASP.NET Core Identity
- Entity Framework Core
- SQLite
- Bootstrap

## Database Setup

SkillShare uses SQLite. Each team member creates their own local database using Entity Framework Core migrations.

To set up the database and run the application:

```bash
dotnet restore
dotnet ef database update
dotnet run
```

The database file is excluded from GitHub, but migrations are shared with the team.

## Team

The Debuggers - 3 Students
