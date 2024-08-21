Sample app to demonstrate working with SqlLite database in Visual Studio Code C# Console Application

To add SQLite to your C# console application, follow these steps:

1. Install the SQLite NuGet package:
Open the terminal in Visual Studio Code.
Navigate to your project directory.
Run the following command to install the Microsoft.Data.Sqlite package:
    dotnet add package Microsoft.Data.Sqlite

2.Modify Program.cs to use SQLite:

Add the necessary using directives
    using Microsoft.Data.Sqlite;

Create a SQLite connection and perform basic operations like creating a table and inserting data.
