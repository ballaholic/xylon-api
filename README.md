
# Xylon eCommerce Platform

## 📌 Overview
Xylon is a modern **eCommerce platform** built with:
- **ASP.NET Core Web API** (using .NET 9 SDK) for backend services
- **React (Vite) + Tailwind CSS** for frontend
- **Entity Framework Core** for database access

The platform includes:
✔ Static company pages  
✔ Product catalog  
✔ **Advanced Configurator** (multi-step product customization)  
✔ Integrated Chatbot (future feature)  

---

## ⚡ Tech Stack
- **Backend:** ASP.NET Core 9, EF Core
- **Database:** SQL Server
- **Tools:** Swagger

---

## 🚀 Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- [Node.js (v18+)](https://nodejs.org)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (optional)
- SQL Server (local or container)

---

### Backend Setup
1. Navigate to API folder:
   ```bash
   cd src/Web.Api
   ```
2. Install dependencies:
   ```bash
   dotnet restore
   ```
3. Apply migrations:
   ```bash
   dotnet ef database update --project XylonApi
   ```
4. Run the API:
   ```bash
   dotnet run
   ```
5. Access Swagger:
   ```
   https://localhost:5001/swagger
   ```

---

## 📂 Migrations
To create a new migration:
```bash
dotnet ef migrations add <MigrationName> --project XylonApi
dotnet ef database update
```

---

## 📌 Roadmap
- [ ] Add Chatbot integration
- [ ] Implement Payment Gateway
- [ ] Add User Accounts & Authentication
- [ ] Deploy to Azure/AWS

---

## 🤝 Contributing
Pull requests are welcome!  
Please follow the coding standards defined in `.editorconfig`.

---

## 📜 License
This project is licensed under the MIT License.
