using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}