
using System.Data;
using System.Data.SqlClient;

namespace Repositories
{
    using DatenbankEngine;
    using Stapel;
    public class StapelRepository : IStapelRepository
    {
        private readonly SqlFileDatabaseEngine databaseEngine;

        public StapelRepository()
        {
            databaseEngine = new SqlFileDatabaseEngine();
        }

        public Stapel[] GetAlleStapel()
        {
            string sql = "SELECT Id, name FROM Stapel";

            SqlCommand sqlCommand = new SqlCommand(sql);
            
            DataTable dataTable = databaseEngine.ExecuteSelectQuery(sqlCommand);

            Stapel[] stapelArray = new Stapel[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                 int id = (int) dataTable.Rows[index][0];
                 string name =  dataTable.Rows[index][1].ToString();

                 Stapel stapel = new Stapel();

                 stapel.Id = id;
                 stapel.Name = name;

                 stapelArray[index] = stapel;
            }


            return stapelArray;
        }


    }
}