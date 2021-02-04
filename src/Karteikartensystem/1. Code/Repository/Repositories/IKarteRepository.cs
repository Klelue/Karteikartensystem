using System;
using System.Collections.Generic;
using System.Text;
using Model;


namespace Repositories
{
    public interface IKarteRepository : IRepository
    {
        bool KarteHinzufügen(Karte karte);
        Karte[] GetAlleKartenEinesStapels(int stapelId);
        bool KarteLöschen(int id);
    }
}
