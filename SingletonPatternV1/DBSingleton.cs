using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternV1
{
    public class DBSingleton
    {
        private static DBSingleton? _instance;
        private static readonly object _lock = new();
        private SqlConnection _connection;
        private string _connectionString;

        // Private constructor to prevent instantiation from outside
        private DBSingleton(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
        }

        // Public method to provide global access to the instance
        public static DBSingleton GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DBSingleton(connectionString);
                    }
                }
            }
            return _instance;
        }

        // Method to open the connection
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
                Console.WriteLine("Database connection opened.");
            }
        }

        // Method to close the connection
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
                Console.WriteLine("Database connection closed.");
            }
        }

        // Method to get the SqlConnection instance
        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
