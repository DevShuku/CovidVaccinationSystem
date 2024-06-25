# CovidVaccinationSystem Solution
Source code is placed at GitHub https://github.com/DevShuku/CovidVaccinationSystem

# Requirements
It is a source code for designing and implementing a microservice architecture for a COVID vaccination and patient details system 

# Code Development:
  Created API to 
   - GET list of Patients
   - GET a perticular patient data.
   - POST a Patient data
   - PUT -update a patient data
   - DELETE a perticular patient data.
      

📢 This project is built with **.net 8.0

## Swagger Page
      https://localhost:7022/swagger/v1/swagger.json

## Tech stack 
   - Dotnet core 8.0
 
## Database 
    - MySQL 8.4.0 
  
## How to run the project?
On pre installed **Visual Studio 2022** (It is the latest as of June,2024). Now, follow the following steps.
1. Open command prompt. Go to a directory where you want to clone this project. Use this command to clone the project.
   ```
     git clone 
   ```

2. Go to the directory where you have cloned this project, open the directory `CovidVaccinationSystem`. You will find a file with name `CovidVaccinationSystem.sln`. Double click on this file and this project will be opened in Visual Studio.

3.  open `appsettings.json` file and update connection string in your local and run on the localhost after configuring the MySQL datacontext.
 
   ```
     "ConnectionStrings": {

         "DefaultConnection": "Data Source=localhost;Database={Database name};User={username};Password={password};"
       
     }
   ```
4. Now you can run this project

5. Scope of extenstion to this projects are:
   a) Custom Exception handling pages
   b) Unit test implementation.
   c) SonarQube implementation for the code quality purpose 

Thanks a lot 🙂🙂

