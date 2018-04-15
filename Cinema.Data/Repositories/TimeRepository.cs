using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface ITimeRepository : IRepository<Time>
    {
    }

    public class TimeRepository : RepositoryBase<Time>, ITimeRepository
    {
        public TimeRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}