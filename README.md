# BogusApiDemo

A simple ASP.NET Core Web API application that uses the [Bogus](https://github.com/bchavez/Bogus) library to generate realistic fake user data for testing or development purposes.

## 🚀 What is Bogus?

[Bogus](https://github.com/bchavez/Bogus) is a powerful .NET library used to generate fake data such as names, addresses, emails, phone numbers, dates, and more. It's perfect for:
- Unit testing
- Seeding databases
- Creating mock APIs
- UI development without a real backend

This project demonstrates how to integrate Bogus in an ASP.NET Core API and serve fake user data through HTTP endpoints.

---

## 🛠️ Technologies & Tools

- [.NET 6+](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- Bogus (Fake data generator)
- Swagger (OpenAPI UI)

---

## 📦 Required NuGet Packages

| Package | Description | Install Command |
|--------|-------------|-----------------|
| [Bogus](https://www.nuget.org/packages/Bogus) | Main library for generating fake data | `dotnet add package Bogus` |
| [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore) | Adds Swagger support to the API | `dotnet add package Swashbuckle.AspNetCore` |

---
