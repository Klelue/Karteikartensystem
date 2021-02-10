
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

            string sql = $"INSERT INTO Karte (frage, antwort, stapel_id, schwierigkeitsgrad, falsch_antwort1, falsch_antwort2, falsch_antwort3) " +
                         $"VALUES(@Frage, @Antwort, @StapelId, @Schwierigkeitsgrad, @FalschAntwort1, @FalschAntwort2, @FalschAntwort3);";

                SqlCommand sqlCommand = new SqlCommand(sql);

                sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
                sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
                sqlCommand.Parameters.AddWithValue("@FalschAntwort1", karte.FalschAntwort1);
                sqlCommand.Parameters.AddWithValue("@FalschAntwort2", karte.FalschAntwort2);
                sqlCommand.Parameters.AddWithValue("@FalschAntwort3", karte.FalschAntwort3);
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
            string sql = "SELECT Id, frage, antwort, falsch_antwort1, falsch_antwort2, falsch_antwort3, stapel_id, schwierigkeitsgrad, challenge_mode FROM Karte WHERE stapel_id = @StapelId;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("StapelId", stapelId);

            DataTable dataTable = datenbankEngine.ExecuteSelectQuery(sqlCommand);

            Karte[] kartenArray = new Karte[dataTable.Rows.Count];

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                long id = (long) dataTable.Rows[index][0];
                string frage = dataTable.Rows[index][1].ToString();
                string antwort = dataTable.Rows[index][2].ToString();
                string falschAntwort1 = dataTable.Rows[index][3].ToString();
                string falschAntwort2 = dataTable.Rows[index][4].ToString();
                string falschAntwort3 = dataTable.Rows[index][5].ToString();
                long stapelidentifikation = (long) dataTable.Rows[index][6];
                int status = (int) dataTable.Rows[index][7];
                bool challengeMode = (bool)dataTable.Rows[index][8];
                

                Karte karte = new Karte();

                karte.Id = id;
                karte.Frage = frage;
                karte.Antwort = antwort;
                karte.StapelId = stapelidentifikation;
                karte.Schwierigkeitsgrad = status;
                karte.FalschAntwort1 = falschAntwort1;
                karte.FalschAntwort2 = falschAntwort2;
                karte.FalschAntwort3 = falschAntwort3;
                karte.ChallengeMode = challengeMode;

                    kartenArray[index] = karte;
            }


            return kartenArray;
        }


        public bool KarteLöschen(long id)
        {
            string sql = "DELETE FROM Karte WHERE Id = @Id";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", id);

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

            string sql = "UPDATE Karte SET frage = @Frage, antwort = @Antwort, falsch_antwort1 = @FalschAntwort1" +
                         ", falsch_antwort2 = @FalschAntwort2, falsch_antwort3 = @FalschAntwort3, stapel_id = @StapelId, schwierigkeitsgrad = @Schwierigkeitsgrad WHERE Id = @Id;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("@Id", karte.Id);
            sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
            sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
            sqlCommand.Parameters.AddWithValue("@FalschAntwort1", karte.FalschAntwort1);
            sqlCommand.Parameters.AddWithValue("@FalschAntwort2", karte.FalschAntwort2);
            sqlCommand.Parameters.AddWithValue("@FalschAntwort3", karte.FalschAntwort3);
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
