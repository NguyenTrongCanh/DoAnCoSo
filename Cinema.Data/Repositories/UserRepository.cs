using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}