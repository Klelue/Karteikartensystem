

using System.Collections.Generic;
using System.Linq;
using Model;
using Repositories;

namespace AnsichtsFenster.Controller
{
    public class StapelController
    {
        private StapelRepository repository;
        public StapelController()
        {
            repository = new StapelRepository();
        }

      
        public List<Stapel> GetAlleStapel()
        {
            return repository.GetAlleStapel().ToList();
        }


        public Stapel GetStapel(string name)
        {
            return repository.GetAlleStapel().First(stapel => stapel.Name == name);
        }

        public bool Aktualisieren(Stapel stapel)
        {
            return repository.StapelAktualisieren(stapel);
        }

        public bool Löschen(long stapelId)
        {
            return repository.StapelLöschen(stapelId);
        }

        public bool Hinzufügen(Stapel stapel)
        {
            return repository.StapelHinzufügen(stapel);
        }

        
    }
}
