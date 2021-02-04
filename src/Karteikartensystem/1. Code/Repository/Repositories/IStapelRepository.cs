using Model;

namespace Repositories
{
    public interface IStapelRepository : IRepository
    {
       Stapel[] GetAlleStapel();
       bool StapelHinzufügen(Stapel stapel);
    }
}