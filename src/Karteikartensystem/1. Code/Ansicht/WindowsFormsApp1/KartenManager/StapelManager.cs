using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace AnsichtsFenster.KartenManager
{
    public class StapelManager
    {
        private List<Karte> leichteKarten { get; }
        private List<Karte> mittelKarten { get; }
        private List<Karte> schwereKarten { get; }
        private List<Karte> gelernteKarten { get; }

        public int counter;

        public StapelManager(Karte[] karten)
        {
            leichteKarten = new List<Karte>();
            mittelKarten = new List<Karte>();
            schwereKarten = new List<Karte>();
            gelernteKarten = new List<Karte>();

            KartenAufDieStapelVerteilen(karten);

            this.counter = 0;
        }

        public void Reset()
        {
            List<Karte> karten = new List<Karte>();

            foreach (Karte karte in getAlleKarten())
            {
                karte.Status = 0;
                karten.Add(karte);
            }

            KartenAufDieStapelVerteilen(karten.ToArray());
        }

        private void KartenAufDieStapelVerteilen(Karte[] karten)
        {
            foreach (Karte karte in karten)
            {
                if (karte.Status == 0)
                {
                    schwereKarten.Add(karte);
                }

                if (karte.Status == 1)
                {
                    mittelKarten.Add(karte);
                }

                if (karte.Status == 2)
                {
                    leichteKarten.Add(karte);
                }

                if (karte.Status == 3)
                {
                    gelernteKarten.Add(karte);
                }

            }

        }

        public void RemoveKarte(Karte karte)
        {
            if (karte.Status == 0)
            {
                schwereKarten.Remove(karte);
            }

            if (karte.Status == 1)
            {
                mittelKarten.Remove(karte);
            }

            if (karte.Status == 2)
            {
                leichteKarten.Remove(karte);
            }


        }

        public void AddZuSchwereKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Status = 0;
            schwereKarten.Add(karte);
            
        }

        public void AddZuMittelKarten(Karte karte)
        {

            RemoveKarte(karte);
            karte.Status = 1;
            mittelKarten.Add(karte);
        }

        public void AddZuLeichteKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Status = 2;
            leichteKarten.Add(karte);
        }

        public void AddZuGelerntenKarten(Karte karte)
        {
            RemoveKarte(karte);
            karte.Status = 3;
            gelernteKarten.Add(karte);
        }

        public Karte GetNextKarte()
        {
            counter++;
            Random random = new Random();

            if (counter % 5 == 0 && leichteKarten.Count > 0)
            {
                int index = random.Next(leichteKarten.Count);
                return leichteKarten[index];
            }

            if (counter % 3 == 0 && mittelKarten.Count > 0)
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

        public Karte[] getAlleKarten()
        {
            return schwereKarten.Concat(mittelKarten).Concat(leichteKarten).Concat(gelernteKarten).ToArray();
        }
    }
}
