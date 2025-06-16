# 🤣 JokesWebApp

A simple and fun ASP.NET Core MVC application that lets users browse, search, and manage jokes. Built with .NET Core and Bootstrap.

---

## 🚀 Features

- 📝 Create, Read, Update, Delete (CRUD) jokes
- 🔍 Search functionality
- 🎨 Responsive design using Bootstrap
- 🔐 Basic user authentication (Login/Register)
- 📁 MVC architecture for clean separation of concerns

---

## 🛠️ Tech Stack

- ASP.NET Core MVC
- Entity Framework Core
- Bootstrap 5
- C#
- Razor Pages

---

## 📸 Screenshots

![Homepage Screenshot](screenshots/home.png)  
*The main homepage of JokesWebApp*

---

## ⚙️ Setup & Run Locally

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Visual Studio 2022+ or VS Code
- Git

### Clone the Repository

```bash
git clone https://github.com/yourusername/jokeswebapp.git
cd jokeswebapp


Run the App
bash
Copy
Edit
dotnet restore
dotnet build
dotnet run
Then open: https://localhost:44313/

🔐 Authentication
This app includes a basic login and register system using the built-in Identity framework. Customize via _LoginPartial.cshtml.

📂 Project Structure
bash
Copy
Edit
jokeswebapp/
│
├── Controllers/       # All controller logic
├── Views/             # Razor views per controller
├── Models/            # C# classes for data models
├── Data/              # EF Core DBContext
├── wwwroot/           # Static files (CSS, JS, etc.)
└── appsettings.json   # App config
📢 Contribute
Got a joke or a feature idea? Feel free to open issues or pull requests!

📄 License
MIT License — feel free to use and modify!

🙋‍♂️ Author
Kushagra Agarwal
LinkedIn • GitHub

🧠 Fun Fact
Why did the programmer go broke?

Because he used up all his cache.
