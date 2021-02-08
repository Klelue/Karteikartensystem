using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace Repositories
{
    public interface IKarteRepository : IRepository
    {
        bool KarteHinzufügen(Karte karte);
        Karte[] GetAlleKartenEinesStapels(long stapelId);
        bool KarteLöschen(long id);
        bool KarteAktualisieren(Karte karte);
        int AlleKartenEinesStapelsLöschen(long stapelId);
    }
}
