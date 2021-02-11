using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class KarteController
    {
        private KarteRepository repository;

        public KarteController()
        {
            repository = new KarteRepository();
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

        public List<Karte> getAlleKartenEinesStapels(long id)
        {
            return repository.GetAlleKartenEinesStapels(id).ToList();
        }

        public int CountAlleKartenEinesStapels(long stapelId)
        {
            return repository.GetAlleKartenEinesStapels(stapelId).Length;
        }
    }

}
