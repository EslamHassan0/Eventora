# Eventora 🎉

**Eventora** is a modern and modular application designed to manage events, weddings, and celebrations of all kinds. It supports **Multi-Tenancy**, making it ideal for companies managing multiple branches or clients.

---

## 🧱 Project Architecture

Eventora is structured following a **Layered Architecture**, which provides clear separation of concerns, improves scalability, and simplifies maintenance.

### 📦 Solution Structure

- **Eventora.Application**  
  Contains the business logic and application services.

- **Eventora.Application.Contracts**  
  Includes interfaces and DTOs used for communication between layers.

- **Eventora.Domain**  
  Holds domain entities and core business rules.

- **Eventora.Domain.Shared**  
  Contains constants, enums, and shared types used across the solution.

- **Eventora.Infrastructure**  
  Manages infrastructure-related operations like database access, repository implementations, and integrations.

- **Eventora.WebAPI**  
  The main entry point of the application. It exposes RESTful APIs via controllers.

---

## 🔧 Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- C#
- Multi-Tenancy support
- Clean/Layered Architecture principles

---

## 🚀 Features

- Full Multi-Tenancy support
- Manage event types (Weddings, Conferences, etc.)
- Clear separation of responsibilities
- Scalable and maintainable architecture

---

## 🛠️ Status

This project is currently under development.  
Upcoming improvements:
- Advanced admin dashboard
- Enhanced user experience

---

## 🤝 Contributions

Contributions and suggestions are welcome!  
Feel free to open issues or submit pull requests.

---

## 📄 License

This project is licensed under the MIT License.

---

> Built with care to simplify event management through a scalable and modern architecture.
