
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

            string sql = $"INSERT INTO Karte (frage, antwort, stapel_id, schwierigkeitsgrad) VALUES(@Frage, @Antwort, @StapelId, @Schwierigkeitsgrad;";

                SqlCommand sqlCommand = new SqlCommand(sql);

                sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
                sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
                sqlCommand.Parameters.AddWithValue("@StapelId", karte.StapelId);
                sqlCommand.Parameters.AddWithValue("@Schwierigkeitsgrad", karte.Schwierigkeitsgrad);

                int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

                if (anzahlBetrofenderReihen == 0)
                {
                    return false;
                }

                return true;

        }

        public Karte[] GetAlleKartenEinesStapels(long stapelId)
        {
            string sql = "SELECT Id, frage, antwort, stapel_id, schwierigkeitsgrad FROM Karte WHERE stapel_id = @StapelId;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("StapelId", stapelId);

            DataTable dataTable = datenbankEngine.ExecuteSelectQuery(sqlCommand);

            Karte[] kartenArray = new Karte[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                long id = (long) dataTable.Rows[index][0];
                string frage = dataTable.Rows[index][1].ToString();
                string antwort = dataTable.Rows[index][2].ToString();
                long stapelidentifikation = (long) dataTable.Rows[index][3];
                int status= (int) dataTable.Rows[index][4];

                Karte karte = new Karte();

                karte.Id = id;
                karte.Frage = frage;
                karte.Antwort = antwort;
                karte.StapelId = stapelidentifikation;
                karte.Schwierigkeitsgrad = status;

                kartenArray[index] = karte;
            }


            return kartenArray;
        }


        public bool KarteLöschen(long Id)
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

        public int AlleKartenEinesStapelsLöschen(long stapelId)
        {
            string sql = "DELETE FROM Karte WHERE stapel_id = @StapelId";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@StapelId", stapelId);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);


            return anzahlBetrofenderReihen;
        }

        public bool KarteAktualisieren(Karte karte)
        {

            string sql = "UPDATE Karte SET frage = @Frage, antwort = @Antwort, stapel_id = @StapelId, schwierigkeitsgrad = @Schwierigkeitsgrad WHERE Id = @Id;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", karte.Id);
            sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
            sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
            sqlCommand.Parameters.AddWithValue("@StapelId", karte.StapelId);
            sqlCommand.Parameters.AddWithValue("@Schwierigkeitsgrad", karte.Schwierigkeitsgrad);

            int anzahlBetrofenderReihen = datenbankEngine.ExecuteQuery(sqlCommand);

            if (anzahlBetrofenderReihen == 0)
            {
                return false;
            }

            return true;
        }
    }
}
