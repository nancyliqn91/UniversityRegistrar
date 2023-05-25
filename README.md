# University Registrar

#### By _Qian Li_ _Joe Wahbeh_ 😊

#### This is our c# practice project which creates an app for a University Registrar to keep track of students and courses.

## Technologies Used

* C#
* .NET
* HTML
* MVC
* Entity Framework
* MySQL Workbench
* VS code

## Description

* As a registrar, user can enter a student and keep track of all students enrolled at this University. User is able to provide a name and date of enrollment.
* As a registrar, user can enter a course and keep track of all of the courses the University offers. User is able to provide a course name and a course number (ex. HIST100).
* As a registrar, user is able to assign students to a course, so that teachers know which students are in their course. A course can have many students and a student can take many courses at the same time.

## Setup/Installation Requirements

* _Clone “University Registrar“ from the repository to your desktop_.
* _Navigate to "University Registrar" directory via your local terminal command line_.
* Run the app, first navigate to this project's production directory called "UniversityRegistrar". 
* Add appsettings.json file, please see the "Database Connection String Setup" instruction below.
* Create the database using the migrations in the `UniversityRegistrar` project. Open your shell (e.g., Terminal or GitBash) to the production directory `UniversityRegistrar`, and `run dotnet ef database update`.
* To optionally create a migration, run the command `dotnet ef migrations add MigrationName` where MigrationName is your custom name for the migration in UpperCamelCase.
* Within the production directory `UniversityRegistrar`, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
* Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Database Connection String Setup 

* Create an appsetting.json file in the "University Registrar" directory of the project. The example is below.
* Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL Workbench.
* Please add this appsettings.json file to the .gitignore file before push this cloned project to a public-facing repository.

```
University Registrar/UniversityRegistrar/appsettings.json

 {
    "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;
      database=qian_li;uid=[YOUR-USER-HERE];
      pwd=[YOUR-PASSWORD-HERE];"
    }
 }
```

## Known Bugs

No bugs 

## License
[MIT](license.txt)
Copyright (c) 2023 Qian Li
