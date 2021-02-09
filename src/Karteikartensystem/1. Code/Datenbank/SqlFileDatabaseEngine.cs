
using System;
using System.Configuration;

namespace DatenbankEngine
{
    using System.Data;
    using System.Data.SqlClient;

    public class SqlFileDatabaseEngine : IDatenbankEngine

    {
        private readonly SqlConnection connection;

        private string fileDatabasePath = ConfigurationManager.ConnectionStrings["Path"].ConnectionString;

        public SqlFileDatabaseEngine()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" 
                                   + fileDatabasePath 
                                   + "Integrated Security=True;Connect Timeout=30";

            connection = new SqlConnection(connectionString);
        }

        
        public DataTable ExecuteSelectQuery(SqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();

            connection.Open();

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
                connection.Close();
            }

            return dataTable;
        }

        public int ExecuteQuery(SqlCommand sqlCommand)
        {

            int rowsAffected;

            Console.WriteLine(sqlCommand);

            sqlCommand.Connection = connection; 

            connection.Open();

            try
            {
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected;
        }

    }
}
