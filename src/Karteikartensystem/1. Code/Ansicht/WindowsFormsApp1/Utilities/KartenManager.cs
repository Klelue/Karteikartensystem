using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace AnsichtsFenster.Utilities
{
    public class KartenManager
    {
        private List<Karte> leichteKarten { get; }
        private List<Karte> mittelKarten { get; }
        private List<Karte> schwereKarten { get; }
        private List<Karte> gelernteKarten { get; }

        private int zähler;

        public KartenManager(Karte[] karten)
        {
            leichteKarten = new List<Karte>();
            mittelKarten = new List<Karte>();
            schwereKarten = new List<Karte>();
            gelernteKarten = new List<Karte>();

            KartenAufDieStapelVerteilen(karten);
        }

        public void Reset()
        {
            List<Karte> karten = new List<Karte>();

            foreach (Karte karte in GetAlleKarten())
            {
                karte.Schwierigkeitsgrad = 0;
                karten.Add(karte);
            }

            KartenAufDieStapelVerteilen(karten.ToArray());
        }

        private void KartenAufDieStapelVerteilen(Karte[] karten)
        {
            foreach (Karte karte in karten)
            {
                if (karte.Schwierigkeitsgrad == 0)
                {
                    schwereKarten.Add(karte);
                }

                if (karte.Schwierigkeitsgrad == 1)
                {
                    mittelKarten.Add(karte);
                }

                if (karte.Schwierigkeitsgrad == 2)
                {
                    leichteKarten.Add(karte);
                }

                if (karte.Schwierigkeitsgrad == 3)
                {
                    gelernteKarten.Add(karte);
                }

            }

        }

        public void RemoveKarte(Karte karte)
        {
            if (karte.Schwierigkeitsgrad == 0)
            {
                schwereKarten.Remove(karte);
            }

            if (karte.Schwierigkeitsgrad == 1)
            {
                mittelKarten.Remove(karte);
            }

            if (karte.Schwierigkeitsgrad == 2)
            {
                leichteKarten.Remove(karte);
            }


        }

        public void AddZuSchwereKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 0;
            schwereKarten.Add(karte);
            
        }

        public void AddZuMittelKarten(Karte karte)
        {

            RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 1;
            mittelKarten.Add(karte);
        }

        public void AddZuLeichteKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 2;
            leichteKarten.Add(karte);
        }

        public void AddZuGelerntenKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 3;
            gelernteKarten.Add(karte);
        }
        public Karte GetNextKarte()
        {
            zähler++;
            Random random = new Random();

            if (zähler % 5 == 0 && leichteKarten.Count > 0)
            {
                int index = random.Next(leichteKarten.Count);
                return leichteKarten[index];
            }

            if (zähler % 3 == 0 && mittelKarten.Count > 0)
            {
                int index = random.Next(mittelKarten.Count);
                return mittelKarten[index];
            }

            if (schwereKarten.Count > 0)
            {
                int index = random.Next(schwereKarten.Count);
                return schwereKarten[index];
            }

            if (schwereKarten.Count == 0 && mittelKarten.Count > 0)
            {
                int index = random.Next(schwereKarten.Count);
                return mittelKarten[index];
            }

            if (mittelKarten.Count == 0 && leichteKarten.Count > 0)
            {
                int index = random.Next(mittelKarten.Count);
                return leichteKarten[index];
            }

            return null;
        }

        public Karte[] GetAlleKarten()
        {
            return schwereKarten.Concat(mittelKarten).Concat(leichteKarten).Concat(gelernteKarten).ToArray();
        }
    }
}
