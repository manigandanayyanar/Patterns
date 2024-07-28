using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SingletonPatternV1;

namespace Patterns
{
    public static class Singleton
    {
        public static void GetSingletonInstance()
        {
            string connectionString = "YourDatabaseConnectionStringHere";

            // Get the singleton instance of the database connection
            DBSingleton dbConnection = DBSingleton.GetInstance(connectionString);

            try
            {
                // Open the connection
                dbConnection.OpenConnection();

                // Use the connection (e.g., execute a query)
                SqlConnection connection = dbConnection.GetConnection();
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM YourTableName", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}, {reader[1]}"); // Adjust based on your table structure
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Close the connection
                dbConnection.CloseConnection();
            }
        }

        public static void ThreadSafe()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Thread process1 = new Thread(() =>
            {
                TestSingleton("FOO");
            });
            Thread process2 = new Thread(() =>
            {
                TestSingleton("BAR");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();
        }

        public static void TestSingleton(string value)
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
