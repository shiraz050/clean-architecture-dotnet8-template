# 🧱 Clean Architecture .NET 8 Template

A modular, maintainable, and production-ready boilerplate built using **Clean Architecture** principles and **.NET 8**. Perfect for scalable APIs with clear separation of concerns, modern tooling, and extensibility.

---

## ✨ Features

* ✅ Clean Architecture (Domain, Application, Infrastructure, API)
* ✅ .NET 8 Minimal API
* ✅ EF Core + SQLite (easy DB swap)
* ✅ Swagger UI for API docs
* ✅ Repository Pattern with DI
* ✅ Serilog for logging
* ✅ GitHub-ready for open source

---

## 📁 Project Structure

```
CleanArchitecture/
├── CleanArchitecture.API/           → Minimal API (entry point)
├── CleanArchitecture.Application/   → Interfaces, DTOs, use cases
├── CleanArchitecture.Domain/        → Core entities & business rules
├── CleanArchitecture.Infrastructure/→ EF Core, Repositories, DbContext
```

---

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/shiraz050/clean-architecture-dotnet8-template.git
cd clean-architecture-dotnet8-template
```

### 2. Apply the EF Core migration

```bash
dotnet ef database update --project CleanArchitecture.Infrastructure --startup-project CleanArchitecture.API
```

### 3. Run the API

```bash
dotnet run --project CleanArchitecture.API
```

Then navigate to: [http://localhost:5128/swagger](http://localhost:5128/swagger)

---

## 🛠 Tech Stack

* .NET 8
* EF Core (SQLite default)
* Minimal APIs
* Serilog
* Swagger
* FluentValidation (optional)

---

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature-name`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature-name`)
5. Open a Pull Request

---

## 📄 License

This project is licensed under the MIT License — see the [LICENSE](License) file for details.
