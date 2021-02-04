using Model;

namespace Repositories
{
    public interface IStapelRepository : IRepository
    {
       Stapel[] GetAlleStapel();
       bool AddStapel(Stapel stapel);
    }
}