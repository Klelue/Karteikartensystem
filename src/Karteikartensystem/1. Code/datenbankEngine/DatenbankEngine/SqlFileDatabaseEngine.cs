
using System.Data;
using System.Data.SqlClient;

namespace DatenbankEngine
{
    public class SqlFileDatabaseEngine
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;
        public SqlFileDatabaseEngine()
        {

            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\database\db_test_login.mdf;Integrated Security=True;Connect Timeout=30";

            this.connection = new SqlConnection(this.connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public DataTable ExecuteSql(string selectQuery)
        {
            SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = sqlCommand
            };

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }

        public int ExecuteQuery(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            int deletedRows = sqlCommand.ExecuteNonQuery();

            return deletedRows;
        }

    }
}
