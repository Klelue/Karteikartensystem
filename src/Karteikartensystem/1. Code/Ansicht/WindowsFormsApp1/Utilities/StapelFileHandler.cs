
namespace AnsichtsFenster.Utilities
{
    using Controller;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Model;
    using System.Text;


    public class StapelFileHandler
    {
        private readonly StapelController stapelController;
        private readonly KarteController karteController;
        private readonly string SeparierendesZeichen = "@";

        public StapelFileHandler()
        {
            stapelController = new StapelController();
            karteController = new KarteController();
        }

        public bool StapelAlsSepDateiAnlegen(Stapel stapel, string pfad)
        {
            try
            {
                StringBuilder text = new StringBuilder();

                List<Karte> karten = karteController.GetAlleKartenEinesStapels(stapel.Id);
                foreach (Karte karte in karten)
                {
                    text.AppendFormat($"{karte.Frage}{SeparierendesZeichen}{karte.Antwort}{Environment.NewLine}");
                }

                string dateiName = $@"{pfad}\{stapel.Name}.sed";

                File.WriteAllText(dateiName, text.ToString());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool SepDateiEinlesen(string pfad)
        {
            string stapelName = getKartenNamenVonDateiPfad(pfad);
            Stapel stapel = new Stapel();
            stapel.Name = stapelName;
            stapelController.Hinzufügen(stapel);

            Stapel stapelMitAngelegterId = stapelController.GetStapel(stapelName);
            List<Karte> karten = new List<Karte>();
            string[] lines = File.ReadAllLines(pfad);

            foreach (string line in lines)
            {
                string[] separierterkartenInhalt = line.Split('@');

                Karte karte = new Karte();

                karte.Frage = separierterkartenInhalt[0];
                karte.Antwort = separierterkartenInhalt[1];
                karte.StapelId = stapelMitAngelegterId.Id;
                karte.Schwierigkeitsgrad = 0;
                karte.FalschAntwort1 = "";
                karte.FalschAntwort2 = "";
                karte.FalschAntwort3 = "";

                karten.Add(karte);
            }

            if (!karteController.Hinzufügen(karten))
            {
                return false;
            }

            return true;
        }

        private string getKartenNamenVonDateiPfad(string pfad)
        {
            string[] pfadGesplitet = pfad.Split('\\');
            string dateiname = pfadGesplitet[pfadGesplitet.Length - 1];
            string[] dateinameGesplitet = dateiname.Split('.');

            string dateinameOhneDateiendung = dateinameGesplitet[0];

            return dateinameOhneDateiendung;
        }
    }
}
