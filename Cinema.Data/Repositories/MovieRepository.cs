using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories

{
    public interface IMovieRepository
    {
    }

    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}