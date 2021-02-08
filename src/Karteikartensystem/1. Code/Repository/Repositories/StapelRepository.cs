
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
            string sql = "SELECT Id, name, gelernte_zeit_in_minuten FROM Stapel";

            SqlCommand sqlCommand = new SqlCommand(sql);
            
            DataTable dataTable = datenbankEngine.ExecuteSelectQuery(sqlCommand);

            Stapel[] stapelArray = new Stapel[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                 long id = (long) dataTable.Rows[index][0];
                 string name =  dataTable.Rows[index][1].ToString();
                 long gelernteZeitInMinuten = (long) dataTable.Rows[index][2];

                 Stapel stapel = new Stapel
                {
                    Id = id,
                    Name = name,
                    GelernteZeitInMinuten = gelernteZeitInMinuten
                };

                stapelArray[index] = stapel;
            }


            return stapelArray;
        }

        public bool StapelHinzufügen(Stapel stapel)
        {
            string sql = "INSERT INTO Stapel (name, gelernte_zeit_in_minuten) VALUES(@Name, @GelernteZeitInMinuten);";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Name", stapel.Name);
            sqlCommand.Parameters.AddWithValue("@GelernteZeitInMinuten", stapel.GelernteZeitInMinuten);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;

        }

        public bool StapelLöschen(long id)
        {
            KarteRepository karteRepository = new KarteRepository();

            karteRepository.AlleKartenEinesStapelsLöschen(id);

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

        public bool StapelAktualisieren(Stapel stapel)
        {

            string sql = "UPDATE Stapel SET name = @Name, gelernte_zeit_in_minuten = @GelernteZeitInMinuten WHERE Id = @Id;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", stapel.Id);
            sqlCommand.Parameters.AddWithValue("@Name", stapel.Name);
            sqlCommand.Parameters.AddWithValue("@GelernteZeitInMinuten", stapel.GelernteZeitInMinuten); 
            

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;
        }


    }
}