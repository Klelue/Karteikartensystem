using System.Collections.Generic;
using System.Linq;
using KartenRepository;
using Repositories;
using Stapel;

namespace Controller
{
    public class StapelController
    {
        private StapelRepository stapelRepository;
        private KarteRepository kartenRepository;
        public StapelController()
        {
            stapelRepository = new StapelRepository();
            kartenRepository = new KarteRepository();
        }

        public List<Stapel.Stapel> GetAlleStapelGefülltMitKarten()
        {
            List<Stapel.Stapel> alleStapel = GetAlleStapel();
            foreach (Stapel.Stapel stapel in alleStapel)
            {
                stapel.Karten = GetAlleKartenDatenVomStapel(stapel.Id);
            }

            return alleStapel;
        }

        private List<Stapel.Stapel> GetAlleStapel()
        {
            return stapelRepository.GetAlleStapel().ToList();
        }

        private List<Karte> GetAlleKartenDatenVomStapel(int stapelId)
        {
            return kartenRepository.GetKarten(stapelId).ToList();
        }

        public List<Stapel.Stapel> GetAuswahlStapel(int stapelId)
        {
            return stapelRepository.GetAlleStapel().Where(Stapel => Stapel.Id == stapelId).ToList();
        }
        
        public bool AddNewLeerStapel(string name)
        {
            Stapel.Stapel stapel = new Stapel.Stapel();
            stapel.Name = name;
            //TODO
            //DB REQUEST ADD STAPEL SOLL RETURN DB ID TO STAPEL OBJEKT ERMÖGLICHEN
            return stapelRepository.AddStapel(stapel);
        }

        public void AddNewKarteToStapel(Karte karte, int id)
        {

        }

        /// <summary>
        /// Ersetzt UebersichMethoden.cs
        /// </summary>
        /// <param name="suche"></param>
        /// <param name="suchziel"></param>
        /// <returns></returns>
        public List<Stapel.Stapel> GetSuchergebnisStapelList(string suche, List<Stapel.Stapel> suchziel)
        {
            List<Stapel.Stapel> suchergebnis = new List<Stapel.Stapel>();
            suche = suche.ToLower();

            foreach (Stapel.Stapel stapel in suchziel)
            {
                string stapelNameLower = stapel.Name.ToLower();

                if (stapelNameLower.Contains(suche))
                {
                    suchergebnis.Add(stapel);
                }
            }

            return suchergebnis;
        }
        /// <summary>
        /// Ersetzt UebersichMethoden.cs
        /// </summary>
        /// <param name="suche"></param>
        /// <param name="suchziel"></param>
        /// <returns></returns>
        public List<string> GetSuchergebnisStringList(string suche, List<string> suchziel)
        {
            List<string> suchergebnis = new List<string>();
            suche = suche.ToLower();

            foreach (string stapel in suchziel)
            {
                string stapelLower = stapel.ToLower();

                if (stapelLower.Contains(suche))
                {
                    suchergebnis.Add(stapel);
                }
            }

            return suchergebnis;
        }
    }
}