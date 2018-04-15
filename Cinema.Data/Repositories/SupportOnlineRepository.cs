using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline>
    {
    }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}