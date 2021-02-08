
namespace AnsichtsFenster.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Model;

    public class StapelFileHandler
    {
        public string SeparierendesZeichen { get; set; }
        public bool KartenAlsCsvDateiAnlegen(Karte[] karten, string pfad)
        {
            string text = "";

            foreach (Karte karte in karten)
            {
                text += $"{karte.Frage}{SeparierendesZeichen}{karte.Frage}{Environment.NewLine}";
            }

            try
            {
                File.WriteAllText(text,pfad);
            }
            catch (Exception e)
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
                string[] separierterkartenInhalt = line.Split(Convert.ToChar(SeparierendesZeichen));

                Karte karte = new Karte();

                karte.Frage = separierterkartenInhalt[0];
                karte.Antwort = separierterkartenInhalt[1];

                karten.Add(karte);
            }

            return karten.ToArray();

        }
    }
}
