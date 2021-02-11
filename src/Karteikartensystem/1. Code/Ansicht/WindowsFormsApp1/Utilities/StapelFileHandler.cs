using AnsichtsFenster.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using Model;

namespace AnsichtsFenster.Utilities
{
    public class StapelFileHandler
    {
        private StapelController stapelController;
        private KarteController karteController;
        private string SeparierendesZeichen = "@";

        public StapelFileHandler()
        {
            stapelController = new StapelController();
            karteController = new KarteController();
        }

        public bool StapelAlsSepDateiAnlegen(Stapel stapel, string pfad)
        {
            try
            {
                string text = "";
                List<Karte> karten = karteController.getAlleKartenEinesStapels(stapel.Id);
                foreach (Karte karte in karten)
                {
                    text += $"{karte.Frage}{SeparierendesZeichen}{karte.Antwort}{Environment.NewLine}";
                }

                File.WriteAllText(pfad + @"\" + stapel.Name + ".sed", text);
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
