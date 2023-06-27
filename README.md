# asp.net-registration-login-forms - SE 356 Lecture Project
This ASP.NET MVC project allows users to register and login to the platform using dedicated forms and it uses SQL Server as the database management system.

### Database Table (mvc-project)

| Column Name  | Data Type  | Description       |
|-------------|-------------|----------------|
| id          | INT    | User ID |
| name        | VARCHAR(40) | User name  |
| email       | VARCHAR(40) | User email |
| password      | VARCHAR(20) | User password |
| test      | VARCHAR(40) | Test name |

### Technologies Used
- ASP.NET MVC framework
- C# programming language
- SQL Server database

### Features
User Registration: Users can create new accounts by providing their email address and password. If the email address is already registered, an error mesage is displayed.

User Login: Registered users can log in using their email address and password. If the password is incorrect or the email address is not registered, an error is displayed.

Password Validation: When a user enters an incorrect password during login, a warning message is displayed to inform them about the mistake.

![desktop](https://github.com/isragosterit/asp.net-registration-login-forms/assets/82115269/a9e1b155-6697-4acb-8cb8-ed9f967095b9)
![successfull-login](https://github.com/isragosterit/asp.net-registration-login-forms/assets/82115269/5c32c619-1571-4d83-b560-a021bb4356a9)
![unsecessfull-input](https://github.com/isragosterit/asp.net-registration-login-forms/assets/82115269/439f827b-70b8-43f9-ae19-b631d01efb4f)

### License
This project is licensed under the MIT License.
