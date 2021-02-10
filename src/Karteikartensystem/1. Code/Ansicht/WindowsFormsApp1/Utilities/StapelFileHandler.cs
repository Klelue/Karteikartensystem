namespace AnsichtsFenster.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Model;

    public class StapelFileHandler
    {
        public string SeparierendesZeichen = "@";

        public bool KartenAlsCsvDateiAnlegen(string stapelName, Karte[] karten, string pfad)
        {
            string text = "";

            foreach (Karte karte in karten)
            {
                text += $"{karte.Frage}{SeparierendesZeichen}{karte.Antwort}{Environment.NewLine}";
            }

            try
            {
                File.WriteAllText(pfad + @"\" + stapelName + ".sed", text);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public Karte[] KartenCsvEinlesen(string pfad)
        {
            string[] lines = File.ReadAllLines(pfad);

            List<Karte> karten = new List<Karte>();

            foreach (string line in lines)
            {
                string[] separierterkartenInhalt = line.Split('@');

                Karte karte = new Karte();

                karte.Frage = separierterkartenInhalt[0];
                karte.Antwort = separierterkartenInhalt[1];

                karten.Add(karte);
            }

            return karten.ToArray();
        }
    }
}
