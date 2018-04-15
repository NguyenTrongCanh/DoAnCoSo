using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface ITheaterRepository : IRepository<Theater>
    {
    }

    public class TheaterRepository : RepositoryBase<Theater>, ITheaterRepository
    {
        public TheaterRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        } 
    }
}