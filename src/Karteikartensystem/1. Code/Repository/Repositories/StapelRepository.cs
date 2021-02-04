
namespace Repositories
{
    using DatenbankEngine;
    using System.Data;
    using System.Data.SqlClient;
    using Model;

    public class StapelRepository : IStapelRepository
    {
        private readonly IDatenbankEngine datenbankEngine;

        public StapelRepository()
        {
            datenbankEngine = new SqlFileDatabaseEngine();
        }

        public Stapel[] GetAlleStapel()
        {
            string sql = "SELECT Id, name FROM Stapel";

            SqlCommand sqlCommand = new SqlCommand(sql);
            
            DataTable dataTable = datenbankEngine.ExecuteSelectQuery(sqlCommand);

            Stapel[] stapelArray = new Stapel[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                 int id = (int) dataTable.Rows[index][0];
                 string name =  dataTable.Rows[index][1].ToString();

                 Stapel stapel = new Stapel
                {
                    Id = id,
                    Name = name
                };

                stapelArray[index] = stapel;
            }


            return stapelArray;
        }

        public bool StapelHinzufügen(Stapel stapel)
        {
            string sql = "INSERT INTO Stapel (name) VALUES(@Name);";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Name", stapel.Name);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;

        }

        public bool StapelLöschen(int id)
        {
            string sql = "DELETE FROM Stapel WHERE Id = @Id";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", id);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;
        }


    }
}