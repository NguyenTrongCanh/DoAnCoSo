using Cinema.Data.Infastructure;
using Cinema.Model.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Cinema.Data.Repositories
{
    public interface IPostRepository:IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);

    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}