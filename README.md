APortfolio
APortfolio is a web application inspired by Adobe Portfolio. It allows users to showcase their work by creating personalized portfolios containing multiple projects. Each project can include media such as photos, offering a seamless way to display creativity and skills.

Non-registered users can browse through available projects, while registered users have full access to create, update, and delete projects and media.

Table of Contents
Features
Technology Stack
Installation
Usage
Contributing
License
Features
Portfolio Creation: Each registered user can create a single portfolio.
Project Management: Users can add multiple projects to their portfolio.
Media Upload: Users can upload photos to each project.
Browsing: Non-registered users can browse through all public projects.
CRUD Functionality: Registered users can create, read, update, and delete their projects and media.
Technology Stack
Backend: ASP.NET MVC
Database: SQL Server with Entity Framework Core
Frontend: Razor Views
Languages: C#, HTML, CSS, JavaScript
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/yourusername/APortfolio.git
Navigate to the project directory:

bash
Copy code
cd APortfolio
Set up the database:

Update the connection string in appsettings.json to point to your SQL Server instance.
Apply migrations to set up the database schema:
bash
Copy code
dotnet ef database update
Build and run the application:

bash
Copy code
dotnet run
Open your browser and navigate to http://localhost:5000.

Usage
As a Guest:
Browse through portfolios and projects.
View media uploaded by users.
As a Registered User:
Create a personal portfolio.
Add multiple projects with photos to your portfolio.
Edit or delete projects and media.
