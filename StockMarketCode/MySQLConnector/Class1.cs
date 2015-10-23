using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataGrabber
{
    public class MySQLConnector
    {
        private MySqlConnection connection; // Used to open a connection to the database.
        private string server;              // Indicates where the server is hosted.
        private string database;            // Indicates the name of the database.
        private string uid;                 // Indicates the MySQL username. 
        private string password;            // Indicates the MySQL password.

        // Default Constructor.
        public MySQLConnector()
        {
        }

        // Initialize the values.
        private void Initialize()
        {
            server = "localhost";
            database = "StockData";
            uid = "Admin";
            password = "Kn0wl3dge";

            string connectionString;
            connectionString = String.Concat("SERVER=", server, ";",
                                             "DATABASE=", database, ";",
                                             "UID=", uid, ";",
                                             "PASSWORD=", password, ";");

        }

        // Open a connection to the database.
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password.");
                        break;
                }
                return false;
            }
        }

        // Clost the connection to the database.
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void ExecuteNonQuery(string query)
        {
            // Open connection.
            if (this.OpenConnection() == true)
            {
                // Create the command and assign the query and connection from the constructor.
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public Dictionary<string, string> SelectFromTickerTable(string whereClause)
        {
            string query = "SELECT * FROM ticker_sybols " + whereClause;

            // Create the Dictionary to store the result.
            Dictionary<string, string> result = new Dictionary<string, string>();

            // Open connection.
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                // Read the data and store it in the list.
                while (dataReader.Read())
                {
                    result.Add(dataReader["tick_key"].ToString(), dataReader["tick_sym"].ToString());
                }

                dataReader.Close();
                this.CloseConnection();
            }

            return result;
        }

        public int Count(string tableName)
        {
            string query = "SELECT Count(*) FROM " + tableName;
            int count = -1;

            // Open Connection.
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                count = int.Parse(cmd.ExecuteScalar() + "");

                this.CloseConnection();
            }

            return count;
        }

        public void Backup()
        {

        }

        public void Restore()
        {

        }
    }
}
