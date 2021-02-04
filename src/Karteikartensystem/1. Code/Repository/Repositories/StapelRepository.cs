
namespace Repositories
{
    using DatenbankEngine;
    using System.Data;
    using System.Data.SqlClient;
    using Model;

    public class StapelRepository : IStapelRepository
    {
        private readonly IDatenbankEngine databaseEngine;

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

                Model.Stapel stapel = new Model.Stapel
                {
                    Id = id,
                    Name = name
                };

                stapelArray[index] = stapel;
            }


            return stapelArray;
        }

        public bool AddStapel(Stapel stapel)
        {
            string sql = $"INSERT INTO Stapel (name) VALUES(@Name);";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Name", stapel.Name);

            int anzahlBetrofenderReihen = databaseEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;

        }


    }
}