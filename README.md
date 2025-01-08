# TODO

The //TODO App is a Bugtracker WebApp written in ASP.NET MVC and C#. With a minimalistic style, it provides essential functionalities of a bug tracker suitable for real-world working environments.

---

## Features

### Main Page
The main page ensures security by not displaying information to unauthorized users who have not logged in with valid credentials. 

<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20MainPage.jpeg" alt="Main" width="50%">

### Index Page
The Index page lists all current bugs or feature requests submitted by users. Each item has three options:
1. **Edit**: Update or add more information about the bug or feature.
2. **Details**: View the characteristics in a read-only format.
3. **Delete**: Mark the bug/feature as resolved. Deleted items can be recovered if needed.

### Register Page
Register a new user with an email and password.
<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20RegisterNewAccountPage.jpeg" alt="RegisterNewAccountPage" width="50%">

Receive confirmation upon successful registration.
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20RegisterConfirmationPage.jpeg" alt="RegisterConfirmationPage" width="50%">

Login using your new account credentials.
<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20LoginPage.jpeg" alt="LoginPage" width="50%">

### Edit Page
Submit a new bug fix or feature request.
<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20EditPage.jpeg" alt="Edit" width="50%">

### Details Page
View detailed information about a specific bug or feature.
<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugrtracker%20DetailsPage.jpeg" alt="Details" width="50%">

### Search Page
Search through the list of bugs or features by name.
<br />
<img src="https://github.com/federicopessina/TODO/blob/master/Screenshots/TODOBugtracker%20SearchPage.jpeg" alt="Search" width="50%">

---

## Project Structure

### Key Files and Directories
- **Program.cs**: Entry point of the application.
- **Startup.cs**: Configures services and the app's middleware pipeline.
- **TODO.csproj** & **TODO.sln**: Project and solution files for building the app.
- **appsettings.json**: Configuration settings for the app.
- **Areas/Identity/Pages/_ViewStart.cshtml**: View settings for Identity-related pages.

### Controllers
- **BugsController.cs**: Handles CRUD operations for bugs and features.
- **HomeController.cs**: Manages the main and static pages.

### Data
- **ApplicationDbContext.cs**: Database context using Entity Framework.
- **Migrations/**: Scripts and snapshots for database schema evolution.

### Models
- **Bug.cs**: Represents a bug or feature request entity.
- **ErrorViewModel.cs**: Model for error handling.

### Views
- **Views/Bugs/**: Contains views for bug management (Create, Edit, Delete, Details, Index, and Search).
- **Views/Home/**: Views for the home and privacy pages.
- **Views/Shared/**: Shared layouts and partial views (_Layout.cshtml, _LoginPartial.cshtml, etc.).

### Static Assets
- **wwwroot/**: Contains static files like CSS, JavaScript, and third-party libraries (Bootstrap, jQuery, etc.).

---

## Technologies Used
- **ASP.NET Core**
- **MVC (Model-View-Controller)**
- **Entity Framework (ORM)**

---

## Local Development
To set up the app locally:
1. Open the solution in Visual Studio.
2. In the Package Manager Console, run:
   ```bash
   update-database
3. Verify the database creation in SQL Server Object Explorer.
Future Development
Implement Unit Testing for critical features.
Expand the search functionality to include advanced filters.
Add role-based access control for enhanced security.
