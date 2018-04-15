using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}