using System.Collections.Generic;
using Model;

namespace AnsichtsFenster.Utilities
{
    public static class SuchlistenTool
    {
        //TODO Karte/Stapel als Interface Typ IModel bekommen?
        public static List<Karte> GetSuchergebnis(string suchbegriff, List<Karte> suchliste)
        {
            List<Karte> ergebnisListe = new List<Karte>();
            suchbegriff = suchbegriff.ToLower();

            foreach (Karte karte in suchliste)
            {
                string stapelLower = karte.Frage.ToLower();

                if (stapelLower.Contains(suchbegriff))
                {
                    ergebnisListe.Add(karte);
                }
            }

            return ergebnisListe;
        }

        public static List<Stapel> GetSuchergebnis(string suchbegriff, List<Stapel> suchliste)
        {
            List<Stapel> ergebnisListe = new List<Stapel>();
            suchbegriff = suchbegriff.ToLower();

            foreach (Stapel stapel in suchliste)
            {
                string stapelNameLower = stapel.Name.ToLower();

                if (stapelNameLower.Contains(suchbegriff))
                {
                    ergebnisListe.Add(stapel);
                }
            }

            return ergebnisListe;
        }
    }
}