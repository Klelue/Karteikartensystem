namespace Repositories
{
    using Stapel;
    public interface IStapelRepository : IRepository
    {
       Stapel[] GetAlleStapel();
       bool AddStapel(Stapel stapel);
    }
}