using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Cinema.Data.Infastructure;
using Cinema.Model.Models;
using System.Linq;

namespace Cinema.Data.Repositories
{
    public class MovieCategoryRepository : RepositoryBase<MovieCategory>
    {
        public interface IMovieCategoryRepository
        {
            IEnumerable<MovieCategory> GetByAlias(string alias);
        }
        public MovieCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
            {  

            }
        public IEnumerable<MovieCategory> GetByAlias(string alias)
        {
            return this.DbContext.MovieCategories.Where(x => x.Alias == alias);  
        }
    }
}