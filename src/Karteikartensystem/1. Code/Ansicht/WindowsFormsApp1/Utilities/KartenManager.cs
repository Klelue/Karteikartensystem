
namespace AnsichtsFenster.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Model;
    public class KartenManager
    {
        private int zähler;
        private List<Karte> leichteKarten { get; }
        private List<Karte> mittelKarten { get; }
        private List<Karte> schwereKarten { get; }
        private List<Karte> gelernteKarten { get; }

        public static KartenManager CreateInstance(Karte[] karten)
        {
            return new KartenManager(karten);
        }

        private KartenManager(Karte[] karten)
        {
            this.leichteKarten = new List<Karte>();
            this.mittelKarten = new List<Karte>();
            this.schwereKarten = new List<Karte>();
            this.gelernteKarten = new List<Karte>();
            this.KartenAufDieStapelVerteilen(karten);
        }

        public void Reset()
        {
            List<Karte> karten = new List<Karte>();

            foreach (Karte karte in this.GetAlleKarten())
            {
                karte.Schwierigkeitsgrad = 0;
                karten.Add(karte);
            }

            this.KartenAufDieStapelVerteilen(karten.ToArray());
        }

        public void AddZuSchwereKarten(Karte karte)
        {
            this.RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 0;
            this.schwereKarten.Add(karte);
        }

        public void AddZuMittelKarten(Karte karte)
        {
            this.RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 1;
            this.mittelKarten.Add(karte);
        }

        public void AddZuLeichteKarten(Karte karte)
        {
            this.RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 2;
            this.leichteKarten.Add(karte);
        }

        public void AddZuGelerntenKarten(Karte karte)
        {
            this.RemoveKarte(karte);
            karte.Schwierigkeitsgrad = 3;
            this.gelernteKarten.Add(karte);
        }

        public Karte GetNextKarte()
        {
            this.zähler++;
            Random random = new Random();

            if (this.zähler % 5 == 0 && this.leichteKarten.Count > 0)
            {
                int index = random.Next(this.leichteKarten.Count);
                return this.leichteKarten[index];
            }

            if (this.zähler % 3 == 0 && this.mittelKarten.Count > 0)
            {
                int index = random.Next(this.mittelKarten.Count);
                return this.mittelKarten[index];
            }

            if (this.schwereKarten.Count > 0)
            {
                int index = random.Next(this.schwereKarten.Count);
                return this.schwereKarten[index];
            }

            if (this.schwereKarten.Count == 0 && this.mittelKarten.Count > 0)
            {
                int index = random.Next(this.mittelKarten.Count);
                return this.mittelKarten[index];
            }

            if (this.mittelKarten.Count == 0 && this.leichteKarten.Count > 0)
            {
                int index = random.Next(this.leichteKarten.Count);
                return this.leichteKarten[index];
            }

            return null;
        }

        public Karte[] GetAlleKarten()
        {
            return this.schwereKarten.Concat(this.mittelKarten).Concat(this.leichteKarten).Concat(this.gelernteKarten).ToArray();
        }

        private void KartenAufDieStapelVerteilen(Karte[] karten)
        {
            foreach (Karte karte in karten)
            {
                switch (karte.Schwierigkeitsgrad)
                {
                    case 0:
                        this.schwereKarten.Add(karte);
                        break;
                    case 1:
                        this.mittelKarten.Add(karte);
                        break;
                    case 2:
                        this.leichteKarten.Add(karte);
                        break;
                    case 3:
                        this.gelernteKarten.Add(karte);
                        break;
                }
            }
        }

        private void RemoveKarte(Karte karte)
        {
            switch (karte.Schwierigkeitsgrad)
            {
                case 0:
                    this.schwereKarten.Remove(karte);
                    break;
                case 1:
                    this.mittelKarten.Remove(karte);
                    break;
                case 2:
                    this.leichteKarten.Remove(karte);
                    break;
            }
        }

    }
}
