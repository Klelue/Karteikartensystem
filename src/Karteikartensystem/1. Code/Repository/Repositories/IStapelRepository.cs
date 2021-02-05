using Model;

namespace Repositories
{
    public interface IStapelRepository : IRepository
    {
       Stapel[] GetAlleStapel();
       bool StapelHinzufügen(Stapel stapel);

       bool StapelLöschen(int Id);

       bool StapelAktualisieren(Stapel stapel);
    }
}