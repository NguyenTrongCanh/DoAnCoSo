using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory DbFactory) : base(DbFactory)
        { 
        }
    }
}