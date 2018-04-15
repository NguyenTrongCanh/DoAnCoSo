using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IMovieTagRepository : IRepository<MovieTag>
    {
    }

    public class MovieTagRepository : RepositoryBase<MovieTag>, IMovieTagRepository
    {
        public MovieTagRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        } 
    }
}