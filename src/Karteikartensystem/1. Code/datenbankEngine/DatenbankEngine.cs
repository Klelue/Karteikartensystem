using System.Data;
using System.Data.SqlClient;
namespace DatenbankEngine
{
    public class DatenbankEngine
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;

        public DatenbankEngine()
        {
            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\database\karteiverwaltung-db.mdf;Integrated Security=True;Connect Timeout=30";
            this.connection = new SqlConnection(this.connectionString);

        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public DataTable ExcecuteSql(string sqlQuery)
        {
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = sqlCommand
            };

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            return dataTable;

        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}

