using System;
using System.Collections.Generic;
using System.Text;
using Stapel;

namespace Repositories
{
    interface IKarteRepository : IRepository
    {
        bool AddKarte(Karte karte);
        Karte[] GetKarten(int stapelId);
    }
}
