using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
    }

    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}