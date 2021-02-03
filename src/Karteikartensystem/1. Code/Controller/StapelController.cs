using KartenRepository;
using Repositories;

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

        public void AddAlleKartenToStapelAuswahl()
        {
            //stapelRepository.GetAlleStapel()
        }
    }
}