
namespace DatenbankEngine
{
    using System.Data;
    using System.Data.SqlClient;
<<<<<<< HEAD
    public class SqlFileDatabaseEngine : IDatenbankEngine
=======
    using System.Configuration;

    public class SqlFileDatabaseEngine
>>>>>>> develop
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;

        private string fileDatabasePath = ConfigurationManager.ConnectionStrings["Path"].ConnectionString;

        public SqlFileDatabaseEngine()
        {

            this.connectionString =
<<<<<<< HEAD
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\database\karteiverwaltung-db.mdf;Integrated Security=True;Connect Timeout=30";
=======
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileDatabasePath + "Integrated Security=True;Connect Timeout=30";
>>>>>>> develop

            this.connection = new SqlConnection(this.connectionString);
        }

        
        public DataTable ExecuteSelectQuery(SqlCommand sqlCommand)
        {

            DataTable dataTable = new DataTable();

            this.connection.Open();

            try
            {
                sqlCommand.Connection = connection;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                {
                    SelectCommand = sqlCommand
                };

                sqlDataAdapter.Fill(dataTable);
            }
            finally
            {
                this.connection.Close();
            }

            return dataTable;
        }

        public int ExecuteQuery(SqlCommand sqlCommand)
        {

            int rowsAffected = 0;

            this.connection.Open();

            try
            {
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                this.connection.Close();
            }

            return rowsAffected;
        }

    }
}
