using Cinema.Data.Infastructure;
using Cinema.Model.Models;

namespace Cinema.Data.Repositories
{
    public interface IDayRepository :IRepository<Day>
    {
    }

    public class DayRepository : RepositoryBase<Day>, IDayRepository
    {
        public DayRepository(IDbFactory DbFatory) : base(DbFatory)
        {
        }
    }
}