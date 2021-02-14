using System.Collections.Generic;
using System.Linq;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class KarteController
    {
        private readonly KarteRepository repository;

        public KarteController()
        {
            repository = new KarteRepository();
        }

        public bool Hinzufügen(Karte karte)
        {
            return repository.KarteHinzufügen(karte);
        }

        public bool Hinzufügen(List<Karte> karten)
        {
            foreach (Karte karte in karten)
            {
                if (!repository.KarteHinzufügen(karte))
                {
                    return false;
                }
            }

            return true;
        }

        public bool Löschen(long id)
        {
            return repository.KarteLöschen(id);
        }

        public bool Aktualisieren(Karte karte)
        {
            return repository.KarteAktualisieren(karte);
        }

        public List<Karte> GetAlleKartenEinesStapels(long id)
        {
            return repository.GetAlleKartenEinesStapels(id).ToList();
        }

        public int CountAlleKartenEinesStapels(long stapelId)
        {
            return repository.GetAlleKartenEinesStapels(stapelId).Length;
        }
    }

}
