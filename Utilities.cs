using System;
using Microsoft.Data.Sqlite;

public class Utilities
{
    // Add your utility methods here

    public static void InitiateDatabase()
    {
        string connectionString = "Data Source=sample.db";

         // Create a connection to the database
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Create a table
            var createTableCmd = connection.CreateCommand();
            createTableCmd.CommandText = 
            @"
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL
                );
            ";
            createTableCmd.ExecuteNonQuery();

            // Insert a new user
            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText = 
            @"
                INSERT INTO users (name)
                VALUES ('John Doe');
            ";
            insertCmd.ExecuteNonQuery();
            insertCmd.CommandText = 
            @"
                INSERT INTO users (name)
                VALUES ('Alice Johnson');
            ";
            insertCmd.ExecuteNonQuery();
            insertCmd.CommandText = 
            @"
                INSERT INTO users (name)
                VALUES ('Adam Smith');
            ";
            insertCmd.ExecuteNonQuery();
            insertCmd.CommandText = 
            @"
                INSERT INTO users (name)
                VALUES ('Hank Moody');
            ";
            insertCmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Database initiated");

            }
    }
}