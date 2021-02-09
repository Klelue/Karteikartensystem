using Model;

namespace Repositories
{
    public interface IStapelRepository : IRepository
    {
       Stapel[] GetAlleStapel();
       bool StapelHinzufügen(Stapel stapel);

       bool StapelLöschen(long id);

       bool StapelAktualisieren(Stapel stapel);
    }
}