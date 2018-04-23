using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IFoodRepository : IRepository<Food>
    {
    }

    public class FoodRepository : RepositoryBase<Food>, IFoodRepository
    {
        public FoodRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        } 
    }
}