# SkillShare

SkillShare is a web application developed by The Debuggers
for CSE 325 - .NET Software Development at BYU-Idaho.

## Project Overview

SkillShare connects people who want to learn new skills
with people who are willing to teach them.

## Technologies

- C#
- ASP.NET Core MVC
- Entity Framework Core

download the EF

> dotnet tool install --global dotnet-ef

Set the connection string to supabase project.

> dotnet user-secrets set "ConnectionStrings:DefaultConnection" 'Host=aws-1-us-west-2.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.jjgyulmtkeqjlghjjlko;Password=YOURDATABASEPASSWORDHERE;SSL Mode=Require'

This lists your connectionstrings to help you check your connection.

> dotnet user-secrets list

This is how you update tables in supabase

> dotnet ef migrations add //describe the changes like git commit -m "
> dotnet ef database update

## Team

The Debuggers - 3 Students
