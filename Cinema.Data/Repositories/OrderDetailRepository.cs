using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory DbFactory) : base(DbFactory)
        {
        }
    }
}