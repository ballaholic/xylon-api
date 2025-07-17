
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
- **Frontend:** React 18, Vite, Tailwind CSS
- **Database:** SQL Server
- **Tools:** Docker, Swagger

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

### Frontend Setup
1. Navigate to React app folder:
   ```bash
   cd frontend
   ```
2. Install dependencies:
   ```bash
   npm install
   ```
3. Start development server:
   ```bash
   npm run dev
   ```
4. Open in browser:
   ```
   http://localhost:5173
   ```

---

## 🐳 Run with Docker
Build and run API + SQL Server with Docker:
```bash
docker-compose up --build
```

---

## ✅ Features
- ✅ Product catalog with advanced configuration options
- ✅ React + Tailwind responsive UI
- ✅ Swagger for API documentation
- ✅ Ready for Docker-based deployment

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
