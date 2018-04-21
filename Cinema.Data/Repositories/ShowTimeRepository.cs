using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IShowTimeRepository : IRepository<ShowTime>
    {
    }

    public class ShowTimeRepository : RepositoryBase<ShowTime>, IShowTimeRepository
    {
        public ShowTimeRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}