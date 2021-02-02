
namespace DatenbankEngine
{
    using System.Data;
    using System.Data.SqlClient;
    public class SqlFileDatabaseEngine
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;

        public SqlFileDatabaseEngine()
        {

            this.connectionString =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\C#\database\db_test_login.mdf;Integrated Security=True;Connect Timeout=30";

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
