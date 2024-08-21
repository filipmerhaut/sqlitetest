using System;
using Microsoft.Data.Sqlite;

namespace sqlitetest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SqlLite test");
        Utilities.InitiateDatabase();

        string connectionString = "Data Source=sample.db";

         // Create a connection to the database
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            // Query the database
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT id, name FROM users ORDER BY id;";
            using (var reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var name = reader.GetString(1);
                    Console.WriteLine($"ID: {id}, Name: {name}");
                }
            }
        }
    }
}
