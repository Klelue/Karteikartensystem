
using System.Data;
using System.Data.SqlClient;
using DatenbankEngine;
using Model;

namespace Repositories
{
    public class KarteRepository : IKarteRepository
    {
        private readonly IDatenbankEngine datenbankEngine;

        public KarteRepository()
        {
            datenbankEngine = new SqlFileDatabaseEngine();
        }

        public bool KarteHinzufügen(Karte karte)
        {

            string sql = $"INSERT INTO Karte (frage, antwort, stapel_id) VALUES(@Frage, @Antwort, @StapelId);";

                SqlCommand sqlCommand = new SqlCommand(sql);

                sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
                sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
                sqlCommand.Parameters.AddWithValue("@StapelId", karte.Id);

                int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

                if (anzahlBetrofenderReihen == 0)
                {
                    return false;
                }

                return true;

        }

        public Karte[] GetAlleKartenEinesStapels(int stapelId)
        {
            string sql = "SELECT Id, frage, antwort, stapel_id FROM Karte WHERE stapel_id = @StapelId;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("StapelId", stapelId);

            DataTable dataTable = datenbankEngine.ExecuteSelectQuery(sqlCommand);

            Karte[] kartenArray = new Karte[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                int id = (int)dataTable.Rows[index][0];
                string frage = dataTable.Rows[index][1].ToString();
                string antwort = dataTable.Rows[index][2].ToString();
                int stapelidentifikation = (int) dataTable.Rows[index][3];

                Karte karte = new Karte();

                karte.Id = id;
                karte.Frage = frage;
                karte.Antwort = antwort;
                karte.StapelId = stapelidentifikation;

                kartenArray[index] = karte;
            }


            return kartenArray;
        }


        public bool KarteLöschen(int Id)
        {
            string sql = "DELETE FROM Karte WHERE Id = @Id";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", Id);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;
        }

        public bool KarteAktualisieren(Karte karte)
        {

            string sql = "UPDATE Karte SET frage = @Frage, antwort = @Antwort, stapel_id = @StapelId WHERE Id = @id;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", karte.Id);
            sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
            sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
            sqlCommand.Parameters.AddWithValue("@StapelId", karte.StapelId);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;
        }
    }
}
