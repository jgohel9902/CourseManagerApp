# Course Manager App

A simple web application for managing courses and students. Built with ASP.NET Core MVC, Entity Framework Core, and Bootstrap, this app allows users to create, edit, and manage courses and students, as well as send enrollment confirmation emails.

## Features
- Add, edit, and view courses
- Add students to courses and manage their enrollment status
- Display a list of students for each course
- Send enrollment confirmation emails to students
- Responsive design using Bootstrap
- Uses Entity Framework Core for data persistence

## Technologies Used
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **Bootstrap 5**
- **SQL Server (LocalDB)** for database

## Setup Instructions

1. **Clone the repository**:
    ```bash
    git clone https://github.com/jgohel9902/CourseManagerApp.git
    ```

2. **Install dependencies**:
    - Make sure you have the **.NET SDK** installed on your machine.
    - Open the solution in Visual Studio or your preferred IDE.

3. **Set up the database**:
    - The app uses **SQL Server (LocalDB)**. Ensure your connection string in `appsettings.json` is configured correctly.
    - Run the following commands to create the database:
    ```bash
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. **Run the app**:
    - Start the application using Visual Studio or run:
    ```bash
    dotnet run
    ```

## Contributing
Feel free to fork this repository and make improvements or contribute back with pull requests. If you encounter bugs, please open an issue in the GitHub repository.

## License
This project is open-source and available under the [MIT License](LICENSE).
