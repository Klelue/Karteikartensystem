
using System.Data;
using System.Data.SqlClient;
using DatenbankEngine;
using Model;

namespace Repositories
{
    public class KarteRepository
    {
        private readonly IDatenbankEngine databaseEngine;


        public bool AddKarte(Karte karte)
        {
         
                string sql = $"INSERT INTO Karte (frage, antwort, stapel_id) VALUES(@Frage, @Antwort, @StapelId);";

                SqlCommand sqlCommand = new SqlCommand(sql);

                sqlCommand.Parameters.AddWithValue("@Frage", karte.Frage);
                sqlCommand.Parameters.AddWithValue("@Antwort", karte.Antwort);
                sqlCommand.Parameters.AddWithValue("@StapelId", karte.Id);

                int anzahlBetrofenderReihen = databaseEngine.ExecuteQuery(sqlCommand);

                if (anzahlBetrofenderReihen == 0)
                {
                    return false;
                }

                return true;

        }

        public Karte[] GetKarten(int stapelId)
        {
            string sql = "SELECT Id, frage, antwort, stapel_id FROM Karte WHEARE stapel_id = @StapelId;";

            SqlCommand sqlCommand = new SqlCommand(sql);

            sqlCommand.Parameters.AddWithValue("StapelId", stapelId);

            DataTable dataTable = databaseEngine.ExecuteSelectQuery(sqlCommand);

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

    }
}
